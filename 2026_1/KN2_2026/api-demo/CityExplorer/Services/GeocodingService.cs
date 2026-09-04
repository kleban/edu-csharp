using System.Globalization;
using CityExplorer.DTOs;

namespace CityExplorer.Services;

/// <summary>
/// Реалізація геокодування через Nominatim (OpenStreetMap).
///
/// ✅ Nominatim НЕ потребує реєстрації та API-ключа.
/// Офіційна документація: https://nominatim.org/release-docs/latest/api/Search/
///
/// Важливо: Nominatim вимагає заголовок User-Agent з назвою застосунку.
/// Без нього API може заблокувати запити.
/// Це налаштовується в Program.cs при реєстрації HttpClient.
/// </summary>
public class GeocodingService(HttpClient client, ILogger<GeocodingService> logger) : IGeocodingService
{
    // HttpClient ін'єктується через DI (Typed HttpClient pattern).
    // НЕ використовуємо new HttpClient() — це призводить до socket exhaustion.
    // IHttpClientFactory керує пулом з'єднань та їх lifecycle.

    public async Task<(double Lat, double Lon)?> GetCoordinatesAsync(string cityName)
    {
        try
        {
            var url = $"search?q={Uri.EscapeDataString(cityName)}&format=json&limit=1";

            // GetFromJsonAsync автоматично десеріалізує JSON у List<NominatimResultDto>
            var results = await client.GetFromJsonAsync<List<NominatimResultDto>>(url);

            if (results is null || results.Count == 0)
            {
                logger.LogInformation("Nominatim: місто {City} не знайдено", cityName);
                return null;
            }

            var r = results[0];
            // InvariantCulture важливий: у деяких локалях десятковий роздільник — кома,
            // а Nominatim завжди повертає крапку (1.234 а не 1,234)
            return (
                double.Parse(r.Lat, CultureInfo.InvariantCulture),
                double.Parse(r.Lon, CultureInfo.InvariantCulture)
            );
        }
        catch (Exception ex)
        {
            // Логуємо попередження, але НЕ прокидаємо exception далі.
            // Controller отримає null і покаже fallback-повідомлення у View.
            logger.LogWarning(ex, "Nominatim недоступний для міста {City}", cityName);
            return null;
        }
    }
}
