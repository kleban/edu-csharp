using System.Globalization;
using CityExplorer.DTOs;

namespace CityExplorer.Services;

/// <summary>
/// Сервіс отримання прогнозу погоди через Open-Meteo API.
///
/// ✅ Open-Meteo НЕ потребує реєстрації та API-ключа.
/// Офіційна документація: https://open-meteo.com/en/docs
///
/// Чому НЕ кешуємо погоду?
/// Погода змінюється кожні 15-30 хвилин — кешування на годину дало б застарілі дані.
/// Для навчального прикладу краще показати актуальний результат.
/// У продакшні варто кешувати на 10-15 хвилин.
/// </summary>
public class WeatherService(HttpClient client, ILogger<WeatherService> logger) : IWeatherService
{
    public async Task<CurrentWeatherDto?> GetCurrentWeatherAsync(double lat, double lon)
    {
        try
        {
            // ToString(InvariantCulture) гарантує крапку як десятковий роздільник
            // у URL-параметрах (48.4500 а не 48,4500)
            var url = $"v1/forecast" +
                      $"?latitude={lat.ToString(CultureInfo.InvariantCulture)}" +
                      $"&longitude={lon.ToString(CultureInfo.InvariantCulture)}" +
                      $"&current=temperature_2m,wind_speed_10m,weather_code";

            var response = await client.GetFromJsonAsync<OpenMeteoResponseDto>(url);
            return response?.Current;
        }
        catch (Exception ex)
        {
            logger.LogWarning(ex, "Open-Meteo недоступний для lat={Lat} lon={Lon}", lat, lon);
            return null;
        }
    }
}
