using CsvHelper;
using System.Globalization;
using ForbesRank.DataParser;
using ForbesRank.Core;
using ForbesRank.Core.Entities;

string file_path = "forbes_2022.csv";

var options = new CsvReaderOptions
{
    FormatProvider = CultureInfo.GetCultureInfo("en")
};

using var csv = CsvReader.FromFile("forbes_2022.csv", options);
var data = csv.GetRecords<RankDataItem>().ToList();

// Countries
using (var ctx = new DataContext())
{
    if(!ctx.Countries.Any())
    {
        var countries = data.Select(x=> x.country.Trim()).Where(x=> x.Length > 1).Distinct().ToList();
        foreach(var c in countries)
        {
            ctx.Countries.Add(new Country
            {
                Name = c
            });
        }
        ctx.SaveChanges();
        Console.WriteLine($"Added {ctx.Countries.Count()} countries.");
    }
}
// Categories
using (var ctx = new DataContext())
{
    if (!ctx.Categories.Any())
    {
        ctx.Categories.AddRange(
            data.Select(x => x.category.Trim())
                .Distinct()
                .Select(x=> new Category {  Name = x}));

        ctx.SaveChanges();
        Console.WriteLine($"Added {ctx.Categories.Count()} categories.");
    }
}
// Persons
using (var ctx = new DataContext())
{ ctx.People.RemoveRange(ctx.People.ToList());
        ctx.SaveChanges(); 
    if (!ctx.People.Any())
    {
                     

        foreach (var p in data)
        {
            Console.WriteLine(p.ToString());
            ctx.People.Add(
                new Person
                {
                    Name = p.personName,
                    Age = p.age,
                    Rank = p.rank,
                    Worth = (double)p.finalWorth,
                    DateOfBirth = p.birthDate,
                    Category = ctx.Categories.First(x=> x.Name == p.category.Trim()),
                    Country = p.country is not null && p.country.Length > 1 ? ctx.Countries.First(x=> x.Name == p.country.Trim()) : null
                }
                );
        }

        ctx.SaveChanges();
        Console.WriteLine($"Added {ctx.People.Count()} people.");
    }
}


