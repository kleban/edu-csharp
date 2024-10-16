using CsvHelper;
using ForbesRank.Domain.Context;
using ForbesRank.Domain.DTO;
using System.Globalization;
using ForbesRank.Domain.Models;

IEnumerable<ForbsDataItem> data = new List<ForbsDataItem>();

using (var reader = new StreamReader("forbes_2022_billionaires.csv"))
using (var csv = new CsvReader(reader, new CultureInfo("en")))
{
    data = csv.GetRecords<ForbsDataItem>().ToList();

    // Countries

    var ctx = new ForbesContext();

    ctx.Persons.RemoveRange(ctx.Persons.ToList());
    ctx.SaveChanges();

    ctx.Countries.RemoveRange(ctx.Countries.ToList());
    ctx.SaveChanges();

    Console.WriteLine("Countries removed!");

    var countries = data.Select(x => x.country.Trim())
        .Distinct()
        .Where(x=> x.Length > 1)
        .ToList();

    ctx.Countries.AddRange(countries.Select(x=> new Country { Title = x }));
    ctx.SaveChanges();

    ctx.Categories.RemoveRange(ctx.Categories.ToList());
    ctx.SaveChanges();

    var categories = data.Select(x => x.category.Trim())
        .Distinct()
        .Where(x => x.Length > 1)
        .ToList();

    ctx.Categories.AddRange(categories.Select(x => new Category { Title = x }));
    ctx.SaveChanges();

    var persons = new List<Person>();

    foreach(var item in data)
    {
        persons.Add(new Person
        {
            Age = item.age,
            Name = item.personName,
            Rank = item.rank,
            FinalWorth = (double)item.finalWorth,
            Category = ctx.Categories.FirstOrDefault(x => x.Title == item.category.Trim()),
            Country = ctx.Countries.FirstOrDefault(x => x.Title == item.country.Trim()),
        });
    }

    ctx.Persons.AddRange(persons);
    ctx.SaveChanges();

    Console.WriteLine("Data Reading Finished");
}
