using System.Text.Json.Serialization;

namespace CityExplorer.DTOs;

/// <summary>
/// DTO для кореневого об'єкту відповіді від Open-Meteo API.
/// Open-Meteo — безкоштовний API для прогнозу погоди, НЕ потребує API-ключа.
/// Документація: https://open-meteo.com/en/docs
/// </summary>
public class OpenMeteoResponseDto
{
    /// <summary>Блок з поточними метеоданими (current=temperature_2m,wind_speed_10m,weather_code)</summary>
    [JsonPropertyName("current")]
    public CurrentWeatherDto? Current { get; set; }
}

/// <summary>
/// DTO для поточних погодних умов.
/// Поля відповідають параметрам запиту: current=temperature_2m,wind_speed_10m,weather_code
/// </summary>
public class CurrentWeatherDto
{
    /// <summary>Температура повітря на висоті 2 метри, °C</summary>
    [JsonPropertyName("temperature_2m")]
    public double Temperature { get; set; }

    /// <summary>Швидкість вітру на висоті 10 метрів, м/с</summary>
    [JsonPropertyName("wind_speed_10m")]
    public double WindSpeed { get; set; }

    /// <summary>
    /// WMO Weather Interpretation Code.
    /// 0 = ясно, 1-3 = хмарно, 45/48 = туман, 61-67 = дощ, 71-77 = сніг тощо.
    /// Повний список: https://open-meteo.com/en/docs#weathervariables
    /// </summary>
    [JsonPropertyName("weather_code")]
    public int WeatherCode { get; set; }
}
