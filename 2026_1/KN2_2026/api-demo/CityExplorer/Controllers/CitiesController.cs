using CityExplorer.Data;
using CityExplorer.Models;
using CityExplorer.Services;
using CityExplorer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CityExplorer.Controllers;

/// <summary>
/// MVC Controller для управління містами.
///
/// Відповідає за:
/// - Відображення списку міст (Index)
/// - Збагачену картку міста з даними зовнішніх API (Details)
/// - CRUD-операції (Create, Edit, Delete)
///
/// Всі зовнішні API викликаються через сервісний шар (IGeocodingService тощо),
/// а не напряму у методах Controller — це принцип Single Responsibility.
/// </summary>
public class CitiesController(
    AppDbContext db,
    IGeocodingService geocoding,
    IWeatherService weather,
    ICountryService country) : Controller
{
    public async Task<IActionResult> Index()
    {
        var cities = await db.Cities.OrderBy(c => c.Name).ToListAsync();
        return View(cities);
    }

    /// <summary>
    /// Головний метод — збирає дані з локальної БД + трьох зовнішніх API.
    ///
    /// Потік:
    /// 1. БД → City (локальні дані)
    /// 2. Nominatim → координати (залежить від назви міста з БД)
    /// 3. Open-Meteo → погода (залежить від координат Nominatim)
    /// 4. REST Countries → інфо про країну (незалежно від кроків 2-3)
    ///
    /// Якщо будь-який крок невдалий — застосунок продовжує роботу,
    /// а у ViewModel додається попередження для відображення у View.
    /// </summary>
    public async Task<IActionResult> Details(int id)
    {
        var city = await db.Cities.FindAsync(id);
        if (city is null) return NotFound();

        var vm = new CityDetailsViewModel { City = city };

        // ── Крок 1: Координати з Nominatim ──────────────────────────────────
        // Передаємо "Назва міста, Країна" для точнішого пошуку
        var coords = await geocoding.GetCoordinatesAsync($"{city.Name}, {city.Country}");

        if (coords.HasValue)
        {
            vm.Latitude = coords.Value.Lat;
            vm.Longitude = coords.Value.Lon;

            // ── Крок 2: Погода з Open-Meteo (потрібні координати) ───────────
            var weatherData = await weather.GetCurrentWeatherAsync(coords.Value.Lat, coords.Value.Lon);
            if (weatherData != null)
            {
                vm.Temperature = weatherData.Temperature;
                vm.WindSpeed = weatherData.WindSpeed;
                vm.WeatherDescription = WeatherCodeToDescription(weatherData.WeatherCode);
                vm.WeatherAvailable = true;
            }
            else
            {
                vm.Warnings.Add("Прогноз погоди тимчасово недоступний.");
            }
        }
        else
        {
            vm.Warnings.Add("Координати міста не вдалося визначити. Погода недоступна.");
        }

        // ── Крок 3: Країнознавча інформація (незалежно від координат) ───────
        var countryInfo = await country.GetCountryInfoAsync(city.Country);
        if (countryInfo != null)
        {
            vm.FlagEmoji = countryInfo.Flag;
            vm.CurrencyName = countryInfo.Currencies?.Values.FirstOrDefault()?.Name;
            vm.CurrencySymbol = countryInfo.Currencies?.Values.FirstOrDefault()?.Symbol;
            vm.Languages = string.Join(", ", countryInfo.Languages?.Values ?? Enumerable.Empty<string>());
            vm.CountryInfoAvailable = true;
        }
        else
        {
            vm.Warnings.Add("Інформація про країну тимчасово недоступна.");
        }

        return View(vm);
    }

    // ── CRUD ─────────────────────────────────────────────────────────────────

    public IActionResult Create() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(City city)
    {
        if (!ModelState.IsValid) return View(city);
        db.Cities.Add(city);
        await db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(int id)
    {
        var city = await db.Cities.FindAsync(id);
        return city is null ? NotFound() : View(city);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, City city)
    {
        if (id != city.Id) return BadRequest();
        if (!ModelState.IsValid) return View(city);

        db.Update(city);
        await db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        var city = await db.Cities.FindAsync(id);
        return city is null ? NotFound() : View(city);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var city = await db.Cities.FindAsync(id);
        if (city != null)
        {
            db.Cities.Remove(city);
            await db.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Index));
    }

    // ── Допоміжний метод ─────────────────────────────────────────────────────

    /// <summary>
    /// Перетворює числовий WMO Weather Code у зрозумілий текстовий опис.
    /// Повний список кодів: https://open-meteo.com/en/docs#weathervariables
    /// </summary>
    private static string WeatherCodeToDescription(int code) => code switch
    {
        0           => "☀️ Ясно",
        1 or 2 or 3 => "⛅ Хмарно",
        45 or 48    => "🌫️ Туман",
        51 or 53 or 55 => "🌦️ Мряка",
        61 or 63 or 65 => "🌧️ Дощ",
        71 or 73 or 75 => "❄️ Сніг",
        80 or 81 or 82 => "🌩️ Злива",
        95          => "⛈️ Гроза",
        _           => "🌡️ Змінна погода"
    };
}
