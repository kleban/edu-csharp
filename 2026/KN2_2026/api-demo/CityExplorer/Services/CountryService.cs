using CityExplorer.DTOs;
using Microsoft.Extensions.Caching.Memory;

namespace CityExplorer.Services;

/// <summary>
/// Сервіс отримання країнознавчої інформації через REST Countries API.
///
/// ✅ REST Countries НЕ потребує реєстрації та API-ключа.
/// Офіційна документація: https://restcountries.com/
///
/// Чому кешуємо саме цей сервіс?
/// Валюта, мови та прапор країни змінюються дуже рідко (практично ніколи).
/// Кешування знижує навантаження на зовнішній сервіс та пришвидшує відповідь.
/// TTL = 24 години — розумний компроміс між актуальністю та ефективністю.
///
/// IMemoryCache — вбудований кеш ASP.NET Core, зберігає дані у пам'яті процесу.
/// </summary>
public class CountryService(
    HttpClient client,
    IMemoryCache cache,
    ILogger<CountryService> logger) : ICountryService
{
    public async Task<RestCountryDto?> GetCountryInfoAsync(string countryName)
    {
        // Ключ кешу включає назву країни у нижньому регістрі для уникнення дублікатів
        // (Ukraine і ukraine дадуть один і той самий результат з кешу)
        var cacheKey = $"country:{countryName.ToLowerInvariant()}";

        if (cache.TryGetValue(cacheKey, out RestCountryDto? cached))
        {
            logger.LogDebug("REST Countries: {Country} — відповідь з кешу", countryName);
            return cached;
        }

        try
        {
            // ?fields=... скорочує розмір відповіді — беремо лише потрібні поля
            var url = $"v3.1/name/{Uri.EscapeDataString(countryName)}?fields=name,currencies,languages,flag";

            var results = await client.GetFromJsonAsync<List<RestCountryDto>>(url);
            var result = results?.FirstOrDefault();

            if (result != null)
            {
                // Зберігаємо в кеш на 24 години з абсолютним терміном дії
                cache.Set(cacheKey, result, TimeSpan.FromHours(24));
                logger.LogInformation("REST Countries: {Country} — збережено в кеш на 24 год", countryName);
            }

            return result;
        }
        catch (Exception ex)
        {
            logger.LogWarning(ex, "REST Countries недоступний для {Country}", countryName);
            return null;
        }
    }
}
