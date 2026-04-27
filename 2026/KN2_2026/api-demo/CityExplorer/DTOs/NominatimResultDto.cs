using System.Text.Json.Serialization;

namespace CityExplorer.DTOs;

/// <summary>
/// DTO (Data Transfer Object) для відповіді від Nominatim API.
///
/// Навіщо DTO?
/// Nominatim повертає JSON з полями у snake_case (lat, lon, display_name).
/// C# використовує PascalCase. Атрибут [JsonPropertyName] вказує десеріалізатору,
/// яке поле JSON відповідає якій властивості C#.
///
/// Ми НЕ передаємо цей DTO напряму у View — тільки через ViewModel.
/// Це дозволяє змінити зовнішній API без торкання View-шару.
/// </summary>
public class NominatimResultDto
{
    [JsonPropertyName("lat")]
    public string Lat { get; set; } = "";

    [JsonPropertyName("lon")]
    public string Lon { get; set; } = "";

    /// <summary>Повна відображувана адреса від Nominatim</summary>
    [JsonPropertyName("display_name")]
    public string DisplayName { get; set; } = "";
}
