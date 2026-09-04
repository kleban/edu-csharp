using CityExplorer.Data;
using CityExplorer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CityExplorer.Controllers.Api;

/// <summary>
/// Web API Controller для сутності City.
///
/// Навіщо [ApiController]?
/// - Автоматична валідація ModelState (повертає 400 без ручної перевірки)
/// - Автоматичне читання параметрів з тіла запиту ([FromBody] за замовчуванням)
/// - Кращі повідомлення про помилки у форматі ProblemDetails (RFC 7807)
///
/// Навіщо [ProducesResponseType]?
/// - Swagger генерує точну документацію зі схемами відповідей
/// - Інший розробник бачить контракт API без читання коду
/// - IDE показує підказки при написанні клієнтського коду
/// </summary>
[ApiController]
[Route("api/cities")]
public class CitiesApiController(AppDbContext db) : ControllerBase
{
    /// <summary>Отримати список усіх міст</summary>
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<City>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
        => Ok(await db.Cities.OrderBy(c => c.Name).ToListAsync());

    /// <summary>Отримати місто за ID</summary>
    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(City), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(int id)
    {
        var city = await db.Cities.FindAsync(id);
        return city is null ? NotFound() : Ok(city);
    }

    /// <summary>Додати нове місто</summary>
    [HttpPost]
    [ProducesResponseType(typeof(City), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] City city)
    {
        // [ApiController] вже перевіряє ModelState автоматично —
        // якщо Name порожній, повернеться 400 без додаткового коду
        db.Cities.Add(city);
        await db.SaveChangesAsync();

        // CreatedAtAction повертає 201 Created з заголовком Location,
        // що вказує на URL нового ресурсу (GET /api/cities/{id})
        return CreatedAtAction(nameof(GetById), new { id = city.Id }, city);
    }

    /// <summary>Оновити існуюче місто</summary>
    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(int id, [FromBody] City city)
    {
        if (id != city.Id) return BadRequest("ID у URL не співпадає з ID у тілі запиту.");

        var existing = await db.Cities.FindAsync(id);
        if (existing is null) return NotFound();

        existing.Name = city.Name;
        existing.Country = city.Country;
        existing.Description = city.Description;
        await db.SaveChangesAsync();

        return NoContent(); // 204 — успіх без тіла відповіді (стандарт REST для PUT)
    }

    /// <summary>Видалити місто</summary>
    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var city = await db.Cities.FindAsync(id);
        if (city is null) return NotFound();

        db.Cities.Remove(city);
        await db.SaveChangesAsync();
        return NoContent();
    }
}
