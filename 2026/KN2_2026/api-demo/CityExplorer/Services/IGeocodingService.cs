namespace CityExplorer.Services;

/// <summary>
/// Інтерфейс сервісу геокодування.
///
/// Навіщо інтерфейс?
/// 1. Дозволяє замінити реалізацію (наприклад, перейти від Nominatim до Google Maps)
///    без змін у Controller або інших сервісах.
/// 2. Спрощує тестування: у тестах можна підставити MockGeocodingService.
/// 3. Це принцип Dependency Inversion з SOLID.
/// </summary>
public interface IGeocodingService
{
    /// <summary>
    /// Повертає координати (широта, довгота) для вказаного міста.
    /// Повертає null якщо місто не знайдено або API недоступний.
    /// </summary>
    Task<(double Lat, double Lon)?> GetCoordinatesAsync(string cityName);
}
