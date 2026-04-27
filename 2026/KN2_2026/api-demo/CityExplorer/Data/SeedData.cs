using CityExplorer.Models;

namespace CityExplorer.Data;

/// <summary>
/// Початкове заповнення бази даних тестовими даними.
///
/// Seed-дані запускаються один раз при старті застосунку (якщо БД порожня).
/// Це зручно для демо та навчання — не треба вручну додавати записи.
/// </summary>
public static class SeedData
{
    public static void Initialize(AppDbContext db)
    {
        if (db.Cities.Any()) return; // якщо є хоч один запис — виходимо

        db.Cities.AddRange(
            new City
            {
                Name = "Kyiv",
                Country = "Ukraine",
                Description = "Столиця України, одне з найстаріших міст Східної Європи. " +
                              "Засноване у V–VI столітті, місто з понад 1400-річною історією."
            },
            new City
            {
                Name = "Paris",
                Country = "France",
                Description = "Столиця Франції та один з найвідоміших туристичних центрів світу. " +
                              "Місто мистецтва, моди та гастрономії."
            },
            new City
            {
                Name = "Tokyo",
                Country = "Japan",
                Description = "Столиця Японії та найбільша міська агломерація у світі. " +
                              "Поєднання ультрасучасних технологій та стародавніх традицій."
            },
            new City
            {
                Name = "New York",
                Country = "United States",
                Description = "Найбільше місто США, фінансовий та культурний центр. " +
                              "Відоме Таймс-сквером, Центральним парком та Статуєю Свободи."
            },
            new City
            {
                Name = "Berlin",
                Country = "Germany",
                Description = "Столиця та найбільше місто Германії. " +
                              "Важливий культурний центр з багатою та складною історією XX століття."
            }
        );

        db.SaveChanges();
    }
}
