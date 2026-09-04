using CityExplorer.Models;
using Microsoft.EntityFrameworkCore;

namespace CityExplorer.Data;

/// <summary>
/// Контекст бази даних Entity Framework Core.
///
/// EF Core — ORM (Object-Relational Mapper): він перетворює C#-класи
/// на SQL-таблиці та навпаки, без написання SQL вручну.
///
/// У цьому проєкті використовується SQLite — легка файлова БД,
/// ідеальна для навчальних та демо-проєктів.
/// Файл БД: cityexplorer.db (створюється автоматично при першому запуску).
/// </summary>
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    /// <summary>Таблиця міст. EF Core автоматично створить таблицю "Cities" у SQLite.</summary>
    public DbSet<City> Cities => Set<City>();
}
