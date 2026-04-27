using System.Text.Json.Serialization;

namespace CityExplorer.DTOs;

/// <summary>
/// DTO для відповіді від REST Countries API.
/// REST Countries — безкоштовний API, НЕ потребує реєстрації та API-ключа.
/// Документація: https://restcountries.com/
///
/// Запит: GET /v3.1/name/{countryName}?fields=name,currencies,languages,flag
/// Відповідь: масив об'єктів (бо назва може збігатись для кількох країн)
/// </summary>
public class RestCountryDto
{
    [JsonPropertyName("name")]
    public CountryNameDto? Name { get; set; }

    /// <summary>
    /// Словник валют. Ключ = код ISO 4217 (наприклад "UAH", "EUR").
    /// Значення = об'єкт з назвою та символом.
    /// </summary>
    [JsonPropertyName("currencies")]
    public Dictionary<string, CurrencyDto>? Currencies { get; set; }

    /// <summary>
    /// Словник мов. Ключ = код мови ISO 639, значення = назва мови.
    /// Наприклад: { "ukr": "Ukrainian", "eng": "English" }
    /// </summary>
    [JsonPropertyName("languages")]
    public Dictionary<string, string>? Languages { get; set; }

    /// <summary>Emoji-прапор країни (наприклад 🇺🇦). Повертається як рядок.</summary>
    [JsonPropertyName("flag")]
    public string? Flag { get; set; }
}

public class CountryNameDto
{
    /// <summary>Коротка загальновживана назва країни (наприклад "Ukraine", не "Republic of Ukraine")</summary>
    [JsonPropertyName("common")]
    public string Common { get; set; } = "";
}

public class CurrencyDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("symbol")]
    public string Symbol { get; set; } = "";
}
