using CsvHelper;
using ForbesRank.Domain.Context;
using System.Globalization;
using ForbesRank.Domain.Models;
using ForberRank.DataParser;

IEnumerable<ForbsDataItem> data = new List<ForbsDataItem>();

using (var reader = new StreamReader("forbes.csv"))
using (var csv = new CsvReader(reader, new CultureInfo("en")))
{
    data = csv.GetRecords<ForbsDataItem>().ToList();

    // Countries

    var ctx = new ForbesContext();

    // ctx.Persons.RemoveRange(ctx.Persons.ToList());
    //  ctx.SaveChanges();

    // ctx.Countries.RemoveRange(ctx.Countries.ToList());
    // ctx.SaveChanges();

    //ctx.Categories.RemoveRange(ctx.Categories.ToList());
    //ctx.SaveChanges();

    // Console.WriteLine("Countries removed!");

    List<string> countries = data.Select(x => x.country.Trim())
        .Distinct()
        .Where(x=> x.Length > 1 && x != "Russia")
        .ToList();

    ctx.Countries.AddRange(countries.Select(x=> new Country { Title = x }));
    ctx.SaveChanges();

    var categories = data.Select(x => x.category.Trim())
        .Distinct()
        .Where(x => x.Length > 1)
        .ToList();

    ctx.Categories.AddRange(categories.Select(x => new Category { Title = x }));
    ctx.SaveChanges();

    List<Person> persons = new List<Person>();

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
