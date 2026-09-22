# 🌐 Demo: CityExplorer — ASP.NET MVC + External APIs

> **Призначення:** демонстраційний застосунок для лабораторної роботи  
> «Інтеграція ASP.NET MVC pet-проєкту із зовнішніми API, віддаленими ресурсами даних та власним Web API»

---

## Завдання для Claude Code

Створи повністю робочий ASP.NET MVC (.NET 8) застосунок **CityExplorer**, який демонструє всі вимоги лабораторної роботи.

---

## Сценарій інтеграції

**Назва:** «Збагачена картка туристичного міста»

**Проблема користувача:** адміністратор веде список туристичних міст у локальній БД. Для кожного міста він хоче бачити актуальну погоду, координати і країнознавчу довідку — без ручного оновлення.

**Потік даних:**
1. З локальної SQLite БД береться місто (`City`) — назва, опис, назва країни.
2. Через **Nominatim** отримуються координати (lat/lon).
3. Координати передаються у **Open-Meteo** → прогноз погоди.
4. Назва країни передається у **REST Countries** → валюта, мови, прапор (emoji).
5. Усе збирається в одну `CityDetailsViewModel` і відображається у Razor View.

---

## Технічний стек

- **Framework:** ASP.NET Core MVC (.NET 8)
- **БД:** SQLite + Entity Framework Core (InMemory як fallback для тестів)
- **HTTP:** `IHttpClientFactory` + typed services
- **Resilience:** `Microsoft.Extensions.Http.Resilience` (Polly)
- **Cache:** `IMemoryCache`
- **API Docs:** Swashbuckle (Swagger UI)
- **Тест API:** xUnit (опціонально, якщо є час)

---

## Структура проєкту

```
CityExplorer/
├── Controllers/
│   ├── CitiesController.cs          # MVC — CRUD + Details з зовнішніми API
│   └── Api/
│       └── CitiesApiController.cs   # Web API — GET/POST/PUT/DELETE /api/cities
├── Data/
│   ├── AppDbContext.cs
│   └── SeedData.cs                  # 5 тестових міст
├── Models/
│   └── City.cs                      # Id, Name, Country, Description
├── DTOs/
│   ├── NominatimResultDto.cs
│   ├── OpenMeteoResponseDto.cs
│   └── RestCountryDto.cs
├── ViewModels/
│   └── CityDetailsViewModel.cs      # Агрегована модель для View
├── Services/
│   ├── IGeocodingService.cs / GeocodingService.cs
│   ├── IWeatherService.cs   / WeatherService.cs
│   └── ICountryService.cs   / CountryService.cs
├── Views/
│   ├── Cities/
│   │   ├── Index.cshtml             # Список міст
│   │   └── Details.cshtml           # Збагачена картка міста
│   └── Shared/
│       └── _Layout.cshtml
├── appsettings.json
├── appsettings.Development.json     # (порожній — для user-secrets)
├── appsettings.Development.json.example
├── Program.cs
└── LAB_API.md
```

---

## Детальні вимоги до реалізації

### 1. Модель та БД

```csharp
// Models/City.cs
public class City
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Country { get; set; } = "";
    public string Description { get; set; } = "";
}
```

Seed-дані (5 міст): Kyiv (Ukraine), Paris (France), Tokyo (Japan), New York (USA), Berlin (Germany).

---

### 2. DTO для зовнішніх API

```csharp
// DTOs/NominatimResultDto.cs
public class NominatimResultDto
{
    [JsonPropertyName("lat")]
    public string Lat { get; set; } = "";

    [JsonPropertyName("lon")]
    public string Lon { get; set; } = "";

    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; } = "";
}

// DTOs/OpenMeteoResponseDto.cs
public class OpenMeteoResponseDto
{
    [JsonPropertyName("current")]
    public CurrentWeatherDto? Current { get; set; }
}

public class CurrentWeatherDto
{
    [JsonPropertyName("temperature_2m")]
    public double Temperature { get; set; }

    [JsonPropertyName("wind_speed_10m")]
    public double WindSpeed { get; set; }

    [JsonPropertyName("weather_code")]
    public int WeatherCode { get; set; }
}

// DTOs/RestCountryDto.cs
public class RestCountryDto
{
    [JsonPropertyName("name")]
    public CountryNameDto? Name { get; set; }

    [JsonPropertyName("currencies")]
    public Dictionary<string, CurrencyDto>? Currencies { get; set; }

    [JsonPropertyName("languages")]
    public Dictionary<string, string>? Languages { get; set; }

    [JsonPropertyName("flag")]
    public string? Flag { get; set; }  // emoji flag
}

public class CountryNameDto
{
    [JsonPropertyName("common")]
    public string Common { get; set; } = "";
}

public class CurrencyDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; } = "";
}
```

---

### 3. ViewModel (агрегована модель)

```csharp
// ViewModels/CityDetailsViewModel.cs
public class CityDetailsViewModel
{
    // З БД
    public City City { get; set; } = null!;

    // З Nominatim
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }

    // З Open-Meteo
    public double? Temperature { get; set; }
    public double? WindSpeed { get; set; }
    public string? WeatherDescription { get; set; }
    public bool WeatherAvailable { get; set; }

    // З REST Countries
    public string? CurrencyName { get; set; }
    public string? CurrencySymbol { get; set; }
    public string? Languages { get; set; }
    public string? FlagEmoji { get; set; }
    public bool CountryInfoAvailable { get; set; }

    // Мета
    public DateTime LoadedAt { get; set; } = DateTime.UtcNow;
    public List<string> Warnings { get; set; } = new();
}
```

---

### 4. Сервіси

#### GeocodingService

```csharp
public interface IGeocodingService
{
    Task<(double Lat, double Lon)?> GetCoordinatesAsync(string cityName);
}

public class GeocodingService : IGeocodingService
{
    private readonly HttpClient _client;
    private readonly ILogger<GeocodingService> _logger;

    public GeocodingService(HttpClient client, ILogger<GeocodingService> logger)
    {
        _client = client;
        _logger = logger;
    }

    public async Task<(double Lat, double Lon)?> GetCoordinatesAsync(string cityName)
    {
        try
        {
            var url = $"search?q={Uri.EscapeDataString(cityName)}&format=json&limit=1";
            var results = await _client.GetFromJsonAsync<List<NominatimResultDto>>(url);

            if (results is null || results.Count == 0) return null;

            var r = results[0];
            return (double.Parse(r.Lat, CultureInfo.InvariantCulture),
                    double.Parse(r.Lon, CultureInfo.InvariantCulture));
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Nominatim недоступний для міста {City}", cityName);
            return null;
        }
    }
}
```

#### WeatherService

```csharp
public interface IWeatherService
{
    Task<CurrentWeatherDto?> GetCurrentWeatherAsync(double lat, double lon);
}

public class WeatherService : IWeatherService
{
    private readonly HttpClient _client;
    private readonly ILogger<WeatherService> _logger;

    public WeatherService(HttpClient client, ILogger<WeatherService> logger)
    {
        _client = client;
        _logger = logger;
    }

    public async Task<CurrentWeatherDto?> GetCurrentWeatherAsync(double lat, double lon)
    {
        try
        {
            var url = $"v1/forecast?latitude={lat.ToString(CultureInfo.InvariantCulture)}" +
                      $"&longitude={lon.ToString(CultureInfo.InvariantCulture)}" +
                      $"&current=temperature_2m,wind_speed_10m,weather_code";

            var response = await _client.GetFromJsonAsync<OpenMeteoResponseDto>(url);
            return response?.Current;
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "Open-Meteo недоступний для lat={Lat} lon={Lon}", lat, lon);
            return null;
        }
    }
}
```

#### CountryService (з кешуванням)

```csharp
public interface ICountryService
{
    Task<RestCountryDto?> GetCountryInfoAsync(string countryName);
}

public class CountryService : ICountryService
{
    private readonly HttpClient _client;
    private readonly IMemoryCache _cache;
    private readonly ILogger<CountryService> _logger;

    public CountryService(HttpClient client, IMemoryCache cache, ILogger<CountryService> logger)
    {
        _client = client;
        _cache = cache;
        _logger = logger;
    }

    public async Task<RestCountryDto?> GetCountryInfoAsync(string countryName)
    {
        // Кешуємо на 24 години — країнознавча інформація змінюється рідко
        var cacheKey = $"country:{countryName.ToLowerInvariant()}";

        if (_cache.TryGetValue(cacheKey, out RestCountryDto? cached))
        {
            _logger.LogDebug("Country info for {Country} served from cache", countryName);
            return cached;
        }

        try
        {
            var url = $"v3.1/name/{Uri.EscapeDataString(countryName)}?fields=name,currencies,languages,flag";
            var results = await _client.GetFromJsonAsync<List<RestCountryDto>>(url);
            var result = results?.FirstOrDefault();

            if (result != null)
                _cache.Set(cacheKey, result, TimeSpan.FromHours(24));

            return result;
        }
        catch (Exception ex)
        {
            _logger.LogWarning(ex, "REST Countries недоступний для {Country}", countryName);
            return null;
        }
    }
}
```

---

### 5. Реєстрація в Program.cs

```csharp
// HttpClient для Nominatim — з retry через Polly
builder.Services.AddHttpClient<IGeocodingService, GeocodingService>(client =>
{
    client.BaseAddress = new Uri("https://nominatim.openstreetmap.org/");
    client.DefaultRequestHeaders.UserAgent.ParseAdd("CityExplorer/1.0 (lab-demo)");
    client.Timeout = TimeSpan.FromSeconds(8);
})
.AddStandardResilienceHandler(); // автоматично: timeout + retry + circuit breaker

// HttpClient для Open-Meteo
builder.Services.AddHttpClient<IWeatherService, WeatherService>(client =>
{
    client.BaseAddress = new Uri("https://api.open-meteo.com/");
    client.Timeout = TimeSpan.FromSeconds(8);
})
.AddStandardResilienceHandler();

// HttpClient для REST Countries
builder.Services.AddHttpClient<ICountryService, CountryService>(client =>
{
    client.BaseAddress = new Uri("https://restcountries.com/");
    client.Timeout = TimeSpan.FromSeconds(8);
})
.AddStandardResilienceHandler();

builder.Services.AddMemoryCache();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "CityExplorer API", Version = "v1" });
});

// EF Core + SQLite
builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseSqlite("Data Source=cityexplorer.db"));
```

```csharp
// Middleware pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Seed DB
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
    SeedData.Initialize(db);
}
```

---

### 6. MVC Controller — CitiesController

```csharp
public class CitiesController : Controller
{
    private readonly AppDbContext _db;
    private readonly IGeocodingService _geocoding;
    private readonly IWeatherService _weather;
    private readonly ICountryService _country;

    public CitiesController(AppDbContext db, IGeocodingService geocoding,
        IWeatherService weather, ICountryService country)
    {
        _db = db;
        _geocoding = geocoding;
        _weather = weather;
        _country = country;
    }

    public async Task<IActionResult> Index()
    {
        var cities = await _db.Cities.ToListAsync();
        return View(cities);
    }

    public async Task<IActionResult> Details(int id)
    {
        var city = await _db.Cities.FindAsync(id);
        if (city is null) return NotFound();

        var vm = new CityDetailsViewModel { City = city };

        // Крок 1: Координати з Nominatim
        var coords = await _geocoding.GetCoordinatesAsync($"{city.Name}, {city.Country}");
        if (coords.HasValue)
        {
            vm.Latitude = coords.Value.Lat;
            vm.Longitude = coords.Value.Lon;

            // Крок 2: Погода з Open-Meteo (потрібні координати)
            var weather = await _weather.GetCurrentWeatherAsync(coords.Value.Lat, coords.Value.Lon);
            if (weather != null)
            {
                vm.Temperature = weather.Temperature;
                vm.WindSpeed = weather.WindSpeed;
                vm.WeatherDescription = WeatherCodeToDescription(weather.WeatherCode);
                vm.WeatherAvailable = true;
            }
            else
            {
                vm.Warnings.Add("Прогноз погоди тимчасово недоступний.");
            }
        }
        else
        {
            vm.Warnings.Add("Координати міста не вдалося визначити. Погода недоступна.");
        }

        // Крок 3: Країнознавча інформація з REST Countries (незалежно від координат)
        var countryInfo = await _country.GetCountryInfoAsync(city.Country);
        if (countryInfo != null)
        {
            vm.FlagEmoji = countryInfo.Flag;
            vm.CurrencyName = countryInfo.Currencies?.Values.FirstOrDefault()?.Name;
            vm.CurrencySymbol = countryInfo.Currencies?.Values.FirstOrDefault()?.Symbol;
            vm.Languages = string.Join(", ", countryInfo.Languages?.Values ?? Enumerable.Empty<string>());
            vm.CountryInfoAvailable = true;
        }
        else
        {
            vm.Warnings.Add("Інформація про країну тимчасово недоступна.");
        }

        return View(vm);
    }

    private static string WeatherCodeToDescription(int code) => code switch
    {
        0 => "☀️ Ясно",
        1 or 2 or 3 => "⛅ Хмарно",
        45 or 48 => "🌫️ Туман",
        51 or 53 or 55 => "🌦️ Мряка",
        61 or 63 or 65 => "🌧️ Дощ",
        71 or 73 or 75 => "❄️ Сніг",
        80 or 81 or 82 => "🌩️ Злива",
        95 => "⛈️ Гроза",
        _ => "🌡️ Змінна погода"
    };
}
```

---

### 7. Web API Controller

```csharp
[ApiController]
[Route("api/[controller]")]
public class CitiesApiController : ControllerBase
{
    private readonly AppDbContext _db;

    public CitiesApiController(AppDbContext db) => _db = db;

    /// <summary>Отримати список усіх міст</summary>
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<City>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
        => Ok(await _db.Cities.ToListAsync());

    /// <summary>Отримати місто за ID</summary>
    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(City), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(int id)
    {
        var city = await _db.Cities.FindAsync(id);
        return city is null ? NotFound() : Ok(city);
    }

    /// <summary>Додати нове місто</summary>
    [HttpPost]
    [ProducesResponseType(typeof(City), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] City city)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        _db.Cities.Add(city);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = city.Id }, city);
    }

    /// <summary>Оновити місто</summary>
    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(int id, [FromBody] City city)
    {
        if (id != city.Id) return BadRequest();
        var existing = await _db.Cities.FindAsync(id);
        if (existing is null) return NotFound();

        existing.Name = city.Name;
        existing.Country = city.Country;
        existing.Description = city.Description;
        await _db.SaveChangesAsync();
        return NoContent();
    }

    /// <summary>Видалити місто</summary>
    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var city = await _db.Cities.FindAsync(id);
        if (city is null) return NotFound();
        _db.Cities.Remove(city);
        await _db.SaveChangesAsync();
        return NoContent();
    }
}
```

---

### 8. Views

#### Views/Cities/Index.cshtml

Відображає таблицю міст з кнопкою «Деталі» для кожного.

#### Views/Cities/Details.cshtml

Відображає збагачену картку міста:

```html
<!-- Структура картки (Bootstrap 5) -->
<div class="card mb-3">
  <!-- Заголовок: emoji прапору + назва міста + країна -->
  <div class="card-header">
    @Model.FlagEmoji @Model.City.Name — @Model.City.Country
  </div>
  <div class="card-body">
    <!-- Опис з БД -->
    <p>@Model.City.Description</p>

    <!-- Координати (якщо є) -->
    @if (Model.Latitude.HasValue)
    {
      <p>📍 @Model.Latitude.Value.ToString("F4"), @Model.Longitude.Value.ToString("F4")</p>
    }

    <!-- Погода (якщо є) -->
    @if (Model.WeatherAvailable)
    {
      <p>@Model.WeatherDescription — @Model.Temperature°C, вітер @Model.WindSpeed м/с</p>
    }

    <!-- Країнознавча інформація (якщо є) -->
    @if (Model.CountryInfoAvailable)
    {
      <p>💰 Валюта: @Model.CurrencyName (@Model.CurrencySymbol)</p>
      <p>🗣️ Мови: @Model.Languages</p>
    }

    <!-- Попередження про недоступні API -->
    @foreach (var warning in Model.Warnings)
    {
      <div class="alert alert-warning">⚠️ @warning</div>
    }

    <!-- Мітка часу оновлення -->
    <small class="text-muted">Дані оновлено: @Model.LoadedAt.ToString("HH:mm:ss UTC")</small>
  </div>
</div>
```

---

### 9. Безпека API ключів

Цей демо-проєкт використовує виключно **безкоштовні API без ключів** (Nominatim, Open-Meteo, REST Countries), тому `appsettings.Development.json` залишається порожнім.

Для демонстрації принципу безпечного зберігання ключів додай у `appsettings.Development.json.example`:

```json
{
  "ApiKeys": {
    "Pexels": "YOUR_KEY_HERE",
    "OpenWeatherMap": "YOUR_KEY_HERE"
  }
}
```

І у `.gitignore`:
```
appsettings.Development.json
*.db
```

---

### 10. LAB_API.md

Створи файл `LAB_API.md` у корені проєкту:

```markdown
## Сценарій інтеграції

**Назва:** «Збагачена картка туристичного міста»
**Проблема користувача:** отримати актуальну погоду, координати та країнознавчу
довідку для кожного міста без ручного оновлення.

## Використані зовнішні API

| API | Endpoint | Отримані дані | Кешування |
|---|---|---|---|
| Nominatim | `/search?q=...&format=json` | lat, lon | ні (змінюється рідко, але не кешуємо) |
| Open-Meteo | `/v1/forecast?latitude=...&longitude=...&current=...` | температура, вітер, код погоди | ні |
| REST Countries | `/v3.1/name/{name}?fields=...` | валюта, мови, emoji прапор | **24 год** |

## Fallback-стратегії

- **Nominatim недоступний** → координати = null, погода не завантажується,
  у View показується попередження «Координати міста не вдалося визначити».
- **Open-Meteo недоступний** → `WeatherAvailable = false`,
  у View ховається блок погоди, показується попередження.
- **REST Countries недоступний** → `CountryInfoAvailable = false`,
  у View ховається блок країни, показується попередження.
- **Жоден API не впливає на доступність локальних даних з БД.**

## Resilience (Polly)

Всі три HttpClient зареєстровані з `.AddStandardResilienceHandler()`:
- **Timeout:** 8 сек на запит
- **Retry:** 3 спроби з exponential backoff
- **Circuit Breaker:** автоматично

## Кешування

- `REST Countries` → `IMemoryCache`, ключ `country:{name}`, TTL = 24 год.
- Обґрунтування: валюта, мови та прапор країни змінюються дуже рідко;
  кешування знижує навантаження на зовнішній сервіс.

## Власний Web API

- Controller: `CitiesApiController`
- Swagger UI: `/swagger`
- Тест: `GET /api/cities` → список міст з БД

## Як запустити

1. `dotnet restore`
2. `dotnet run`
3. Відкрити http://localhost:5000
4. Перейти на http://localhost:5000/swagger для тестування API
```

---

## Команди для запуску

```bash
dotnet new mvc -n CityExplorer
cd CityExplorer

# Пакети
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.Extensions.Http.Resilience
dotnet add package Swashbuckle.AspNetCore

# Запуск
dotnet run
```

---

## Що перевірити після запуску

| Перевірка | URL / дія |
|---|---|
| Список міст | `GET /Cities` |
| Збагачена картка (з API) | `GET /Cities/Details/1` |
| Fallback (відімкни інтернет) | Перезавантаж сторінку — побачиш попередження замість падіння |
| Кешування REST Countries | Відкрий Details двічі — другий запит без зовнішнього виклику (перевір логи) |
| Swagger | `GET /swagger` |
| Web API | `GET /api/cities` → JSON-список |
| Web API POST | через Swagger: `POST /api/cities` з тілом `{"name":"Lviv","country":"Ukraine","description":"..."}` |

---

## Пояснення для студентів (коментарі в коді)

Кожен клас і метод має бути **прокоментований українською** у форматі XML-doc або inline-коментарів, які пояснюють:

- чому використовується `IHttpClientFactory` замість `new HttpClient()`
- що робить `AddStandardResilienceHandler()` і чому це важливо
- чому `CountryService` кешує, а `WeatherService` — ні
- як `ViewModel` відокремлює зовнішні DTO від View
- навіщо `[ProducesResponseType]` у API Controller
