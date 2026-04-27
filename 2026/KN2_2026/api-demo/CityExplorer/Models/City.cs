namespace CityExplorer.Models;

/// <summary>
/// Головна сутність — туристичне місто.
/// Зберігається у локальній SQLite БД через Entity Framework Core.
/// </summary>
public class City
{
    public int Id { get; set; }

    /// <summary>Назва міста (використовується як запит до Nominatim та Open-Meteo)</summary>
    public string Name { get; set; } = "";

    /// <summary>Назва країни (використовується як запит до REST Countries)</summary>
    public string Country { get; set; } = "";

    /// <summary>Короткий опис міста — береться з локальної БД, не з зовнішніх API</summary>
    public string Description { get; set; } = "";
}
