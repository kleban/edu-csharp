using CityExplorer.DTOs;

namespace CityExplorer.Services;

public interface ICountryService
{
    /// <summary>
    /// Повертає інформацію про країну за її назвою.
    /// Результат кешується на 24 години — країнознавчі дані змінюються рідко.
    /// Повертає null якщо API недоступний або країна не знайдена.
    /// </summary>
    Task<RestCountryDto?> GetCountryInfoAsync(string countryName);
}
