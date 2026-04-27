using CityExplorer.Configuration;
using CityExplorer.Data;
using CityExplorer.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Http.Resilience;
using Polly;

var builder = WebApplication.CreateBuilder(args);

// ─── MVC ──────────────────────────────────────────────────────────────────────
builder.Services.AddControllersWithViews();

// ─── Swagger / OpenAPI ────────────────────────────────────────────────────────
// Swashbuckle автоматично сканує [ApiController]-и та [ProducesResponseType]-атрибути
// і генерує інтерактивну документацію на /swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new()
    {
        Title = "CityExplorer API",
        Version = "v1",
        Description = "REST API для управління туристичними містами. " +
                      "Демонстраційний проєкт Лабораторної роботи №3."
    });
});

// ─── Entity Framework Core + SQLite ──────────────────────────────────────────
// SQLite зберігає всю БД у одному файлі cityexplorer.db у директорії застосунку
builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")
        ?? "Data Source=cityexplorer.db"));

// ─── IMemoryCache ─────────────────────────────────────────────────────────────
// Вбудований in-memory кеш ASP.NET Core.
// CountryService використовує його для кешування відповідей REST Countries на 24 год.
builder.Services.AddMemoryCache();

// ─── Typed Options для зовнішніх API ─────────────────────────────────────────
//
// Читаємо секцію "ExternalApis" з appsettings.json і десеріалізуємо кожну
// підсекцію у typed клас ApiClientOptions.
//
// Навіщо typed options замість IConfiguration["ExternalApis:Nominatim:BaseUrl"]?
//   1. Type safety — компілятор перевіряє імена властивостей, а не рядки
//   2. IDE автодоповнення при роботі з об'єктом
//   3. Централізована валідація — можна додати [Required], [Range] атрибути
//   4. Легко замінити значення в appsettings.Development.json або через env-змінні
//      без зміни коду (наприклад, ExternalApis__Nominatim__TimeoutSeconds=10)
//
// GetRequiredSection() кидає виняток при старті якщо секція відсутня —
// краще дізнатись про помилку конфігурації одразу, ніж при першому запиті.
// Get<T>() десеріалізує JSON-секцію у C#-об'єкт.
var nominatimOpts     = builder.Configuration.GetRequiredSection("ExternalApis:Nominatim").Get<ApiClientOptions>()!;
var openMeteoOpts     = builder.Configuration.GetRequiredSection("ExternalApis:OpenMeteo").Get<ApiClientOptions>()!;
var restCountriesOpts = builder.Configuration.GetRequiredSection("ExternalApis:RestCountries").Get<ApiClientOptions>()!;

// Також реєструємо у DI — якщо знадобиться читати опції безпосередньо у сервісах
// через IOptionsSnapshot<ApiClientOptions> або IOptions<ApiClientOptions>
builder.Services.Configure<ApiClientOptions>("Nominatim",
    builder.Configuration.GetRequiredSection("ExternalApis:Nominatim"));
builder.Services.Configure<ApiClientOptions>("OpenMeteo",
    builder.Configuration.GetRequiredSection("ExternalApis:OpenMeteo"));
builder.Services.Configure<ApiClientOptions>("RestCountries",
    builder.Configuration.GetRequiredSection("ExternalApis:RestCountries"));

// ─── Typed HttpClient + Resilience (Polly) ────────────────────────────────────
//
// ЧИМ є IHttpClientFactory і навіщо він потрібен?
// ─────────────────────────────────────────────────────────────────────────────
// Якщо писати `new HttpClient()` у кожному сервісі — відбувається "socket exhaustion":
// сокети не звільняються одразу після закриття, накопичуються і вичерпуються.
// IHttpClientFactory керує пулом HttpMessageHandler-ів, повторно їх використовує
// і правильно звільняє. Typed HttpClient (AddHttpClient<IService, Impl>) —
// зручна обгортка: DI сам передає налаштований HttpClient у конструктор сервісу.

// ЩО ТАКЕ POLLY?
// ─────────────────────────────────────────────────────────────────────────────
// Polly — бібліотека патернів стійкості для .NET. Вона перехоплює HTTP-виклики
// і застосовує до них правила: повтор, таймаут, автоматичний вимикач тощо.
// Microsoft.Extensions.Http.Resilience — офіційна інтеграція Polly з IHttpClientFactory.

// ЯК НАЛАШТОВУЄМО:
// ─────────────────────────────────────────────────────────────────────────────
// Порядок шарів у конвеєрі Polly (виконуються ззовні всередину):
//   [1. TotalRequestTimeout] → [2. Retry] → [3. CircuitBreaker] → [4. AttemptTimeout]
//
// Тобто: загальний таймаут охоплює всі спроби разом;
//        таймаут спроби — кожну окрему спробу.
//
// BaseUrl, TimeoutSeconds, MaxRetryAttempts, BreakDurationSeconds — з appsettings.json
// FailureRatio, UseJitter, BackoffType — архітектурні рішення, залишаються в коді

// ── Допоміжна функція: чи варто повторювати запит для цього статус-коду? ──────
static bool IsTransient(HttpResponseMessage? response) =>
    response is null ||
    (int)response.StatusCode >= 500 ||           // 500, 502, 503, 504 — серверні помилки
    response.StatusCode == System.Net.HttpStatusCode.RequestTimeout; // 408

// ── Nominatim (OpenStreetMap) — геокодування ─────────────────────────────────
builder.Services.AddHttpClient<IGeocodingService, GeocodingService>(client =>
{
    // BaseUrl читається з appsettings.json → "ExternalApis:Nominatim:BaseUrl"
    client.BaseAddress = new Uri(nominatimOpts.BaseUrl);
    // Nominatim ВИМАГАЄ заголовок User-Agent — без нього поверне 403
    client.DefaultRequestHeaders.UserAgent.ParseAdd("CityExplorer/1.0 (lab-demo)");
})
.AddResilienceHandler("nominatim", pipeline =>
{
    // Загальний таймаут = (MaxRetryAttempts + 1) * AttemptTimeout + запас
    pipeline.AddTimeout(TimeSpan.FromSeconds(nominatimOpts.TimeoutSeconds * (nominatimOpts.MaxRetryAttempts + 1)));

    // Retry — повторні спроби при тимчасових помилках
    pipeline.AddRetry(new HttpRetryStrategyOptions
    {
        // MaxRetryAttempts з appsettings → кількість повторів можна змінити без перекомпіляції
        MaxRetryAttempts = nominatimOpts.MaxRetryAttempts,

        // Exponential backoff з jitter: 1 сек → 2 сек → 4 сек (+ випадковий зсув)
        // Jitter уникає "thundering herd" — коли всі клієнти
        // одночасно повторюють запит після збою сервера
        Delay = TimeSpan.FromSeconds(1),
        BackoffType = DelayBackoffType.Exponential,
        UseJitter = true,

        // Повторюємо тільки при мережевих помилках або серверних статус-кодах 5xx/408
        ShouldHandle = args => ValueTask.FromResult(
            args.Outcome.Exception is not null || IsTransient(args.Outcome.Result))
    });

    // Circuit Breaker (автоматичний вимикач)
    // Якщо 50%+ запитів за 30 секунд завершились невдачею — "розмикаємо схему":
    // наступні запити одразу повертають BrokenCircuitException без виклику API.
    // Через BreakDurationSeconds — "Half-Open": пробуємо один запит. Успіх → замкнено знову.
    pipeline.AddCircuitBreaker(new HttpCircuitBreakerStrategyOptions
    {
        // Мінімум 5 запитів у вікні вибірки, щоб статистика була значущою
        MinimumThroughput = 5,
        // Якщо 50% запитів — невдачі → розмикаємо
        FailureRatio = 0.5,
        // Ковзне часове вікно для підрахунку статистики
        SamplingDuration = TimeSpan.FromSeconds(30),
        // BreakDurationSeconds з appsettings → час блокування налаштовується ззовні
        BreakDuration = TimeSpan.FromSeconds(nominatimOpts.BreakDurationSeconds),
        ShouldHandle = args => ValueTask.FromResult(
            args.Outcome.Exception is not null || IsTransient(args.Outcome.Result))
    });

    // Таймаут однієї спроби — TimeoutSeconds з appsettings
    // Кожен окремий запит переривається якщо немає відповіді за цей час
    pipeline.AddTimeout(TimeSpan.FromSeconds(nominatimOpts.TimeoutSeconds));
});

// ── Open-Meteo — прогноз погоди ───────────────────────────────────────────────
builder.Services.AddHttpClient<IWeatherService, WeatherService>(client =>
{
    client.BaseAddress = new Uri(openMeteoOpts.BaseUrl);
})
.AddResilienceHandler("open-meteo", pipeline =>
{
    pipeline.AddTimeout(TimeSpan.FromSeconds(openMeteoOpts.TimeoutSeconds * (openMeteoOpts.MaxRetryAttempts + 1)));

    pipeline.AddRetry(new HttpRetryStrategyOptions
    {
        MaxRetryAttempts = openMeteoOpts.MaxRetryAttempts,
        Delay = TimeSpan.FromSeconds(1),
        BackoffType = DelayBackoffType.Exponential,
        UseJitter = true,
        ShouldHandle = args => ValueTask.FromResult(
            args.Outcome.Exception is not null || IsTransient(args.Outcome.Result))
    });

    pipeline.AddCircuitBreaker(new HttpCircuitBreakerStrategyOptions
    {
        MinimumThroughput = 5,
        FailureRatio = 0.5,
        SamplingDuration = TimeSpan.FromSeconds(30),
        BreakDuration = TimeSpan.FromSeconds(openMeteoOpts.BreakDurationSeconds),
        ShouldHandle = args => ValueTask.FromResult(
            args.Outcome.Exception is not null || IsTransient(args.Outcome.Result))
    });

    pipeline.AddTimeout(TimeSpan.FromSeconds(openMeteoOpts.TimeoutSeconds));
});

// ── REST Countries — країнознавча інформація ──────────────────────────────────
builder.Services.AddHttpClient<ICountryService, CountryService>(client =>
{
    client.BaseAddress = new Uri(restCountriesOpts.BaseUrl);
})
.AddResilienceHandler("rest-countries", pipeline =>
{
    pipeline.AddTimeout(TimeSpan.FromSeconds(restCountriesOpts.TimeoutSeconds * (restCountriesOpts.MaxRetryAttempts + 1)));

    pipeline.AddRetry(new HttpRetryStrategyOptions
    {
        MaxRetryAttempts = restCountriesOpts.MaxRetryAttempts,
        Delay = TimeSpan.FromSeconds(1),
        BackoffType = DelayBackoffType.Exponential,
        UseJitter = true,
        ShouldHandle = args => ValueTask.FromResult(
            args.Outcome.Exception is not null || IsTransient(args.Outcome.Result))
    });

    pipeline.AddCircuitBreaker(new HttpCircuitBreakerStrategyOptions
    {
        MinimumThroughput = 5,
        FailureRatio = 0.5,
        SamplingDuration = TimeSpan.FromSeconds(30),
        BreakDuration = TimeSpan.FromSeconds(restCountriesOpts.BreakDurationSeconds),
        ShouldHandle = args => ValueTask.FromResult(
            args.Outcome.Exception is not null || IsTransient(args.Outcome.Result))
    });

    pipeline.AddTimeout(TimeSpan.FromSeconds(restCountriesOpts.TimeoutSeconds));
});

// ─── Build ────────────────────────────────────────────────────────────────────
var app = builder.Build();

// ─── Middleware Pipeline ──────────────────────────────────────────────────────
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Swagger тільки у Development режимі
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "CityExplorer API v1");
        c.DocumentTitle = "CityExplorer — API Документація";
    });
}

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// ─── Seed Database ────────────────────────────────────────────────────────────
// EnsureCreated() створює схему БД (таблиці) якщо файл cityexplorer.db не існує.
// SeedData.Initialize() заповнює 5 тестових міст якщо таблиця порожня.
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.EnsureCreated();
    SeedData.Initialize(dbContext);
}

app.Run();
