using CsvHelper;
using Forbes.Core.Context;
using Forbes.Core.Entities;
using Forbes.DataParser;
using System.Globalization;

List<CsvPerson> data = new List<CsvPerson>();

using (var reader = new StreamReader("forbes.csv"))
using (var csv = new CsvReader(reader, new CultureInfo("en")))
{
    data = csv.GetRecords<CsvPerson>().ToList();
}

for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"{data[i].rank}. {data[i].personName} - ${data[i].finalWorth}");
}

ForbesContext context = new ForbesContext();
/*var countries = data.Select(x => x.country.Trim())
    .Distinct().Where(x => !string.IsNullOrWhiteSpace(x))
    .Where(x => x != "Russia")
    .Select(x => new Country { Name = x }).ToList();
context.AddRange(countries);
context.SaveChanges();
var categories = data.Select(x => x.category.Trim())
    .Distinct()
    .Select(x => new Category { Name = x }).ToList();
context.Categories.AddRange(categories);
context.SaveChanges();
Console.WriteLine("DONE!");*/

foreach(var p in data)
{
    Country country = (p.country is not null) ? context.Countries.FirstOrDefault(x => x.Name == p.personName.Trim()) : null;

    context.Persons.Add(new Person
    {
        Age = p.age,
        Name = p.personName,
        Rank = p.rank,
        Worth = p.finalWorth,
        Country = country,
        Category = context.Categories.First(x=> x.Name == p.category.Trim())
    });

    
}

context.SaveChanges();