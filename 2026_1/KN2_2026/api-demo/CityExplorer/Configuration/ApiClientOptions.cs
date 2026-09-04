namespace CityExplorer.Configuration;

/// <summary>
/// Typed Options для одного зовнішнього API-клієнта.
///
/// Патерн IOptions&lt;T&gt;:
///   Замість читання рядків через IConfiguration["ExternalApis:Nominatim:BaseUrl"]
///   ASP.NET Core десеріалізує секцію appsettings.json у цей клас автоматично.
///   Перевагу маємо type safety (рядок "TimeoutSeconds" → int), IDE-автодоповнення
///   та можливість валідувати значення при старті застосунку.
///
/// Реєстрація у Program.cs:
///   builder.Services.Configure&lt;ApiClientOptions&gt;("Nominatim",
///       builder.Configuration.GetSection("ExternalApis:Nominatim"));
///
/// Читання у Program.cs через GetRequiredSection + Get&lt;T&gt;():
///   var opts = builder.Configuration
///       .GetRequiredSection("ExternalApis:Nominatim")
///       .Get&lt;ApiClientOptions&gt;()!;
/// </summary>
public class ApiClientOptions
{
    /// <summary>Базова адреса API (повинна закінчуватись на /)</summary>
    public string BaseUrl { get; set; } = "";

    /// <summary>Таймаут однієї спроби у секундах</summary>
    public int TimeoutSeconds { get; set; } = 5;

    /// <summary>Кількість повторних спроб після першої невдачі</summary>
    public int MaxRetryAttempts { get; set; } = 3;

    /// <summary>Час (секунди), на який Circuit Breaker блокує запити після спрацювання</summary>
    public int BreakDurationSeconds { get; set; } = 10;
}
