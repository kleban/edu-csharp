using CityExplorer.Models;

namespace CityExplorer.ViewModels;

/// <summary>
/// Агрегована ViewModel для сторінки Details.
///
/// Навіщо ViewModel замість прямого використання DTO?
///
/// 1. DTO відображає структуру зовнішнього JSON — вона може змінитись.
///    ViewModel відображає те, що потрібно View — вона стабільна.
///
/// 2. У View зручно працювати з простими властивостями (string, double?),
///    а не з вкладеними словниками та nullable об'єктами з DTO.
///
/// 3. Якщо один API недоступний — відповідні поля будуть null,
///    а прапори WeatherAvailable / CountryInfoAvailable дозволяють
///    View умовно показувати або ховати блоки.
/// </summary>
public class CityDetailsViewModel
{
    // ─── З локальної БД ───────────────────────────────────────────────────────
    public City City { get; set; } = null!;

    // ─── З Nominatim (геокодування) ──────────────────────────────────────────
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }

    // ─── З Open-Meteo (погода) ───────────────────────────────────────────────
    public double? Temperature { get; set; }
    public double? WindSpeed { get; set; }
    public string? WeatherDescription { get; set; }

    /// <summary>true лише якщо Nominatim повернув координати І Open-Meteo повернув погоду</summary>
    public bool WeatherAvailable { get; set; }

    // ─── З REST Countries (країна) ───────────────────────────────────────────
    public string? CurrencyName { get; set; }
    public string? CurrencySymbol { get; set; }
    public string? Languages { get; set; }
    public string? FlagEmoji { get; set; }

    /// <summary>true якщо REST Countries повернув дані успішно</summary>
    public bool CountryInfoAvailable { get; set; }

    // ─── Мета ────────────────────────────────────────────────────────────────
    /// <summary>Момент збору даних — показується у View як підказка про актуальність</summary>
    public DateTime LoadedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Список попереджень про недоступні API.
    /// View показує кожен елемент як alert-warning, не приховуючи всю сторінку.
    /// Це реалізація Graceful Degradation — застосунок деградує поступово.
    /// </summary>
    public List<string> Warnings { get; set; } = new();
}
