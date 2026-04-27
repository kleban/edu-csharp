using CityExplorer.DTOs;

namespace CityExplorer.Services;

public interface IWeatherService
{
    /// <summary>
    /// Повертає поточні погодні умови для координат.
    /// Повертає null якщо API недоступний.
    /// </summary>
    Task<CurrentWeatherDto?> GetCurrentWeatherAsync(double lat, double lon);
}
