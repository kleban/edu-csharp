
using CsvHelper;
using FrbsApp.Core.Context;
using FrbsApp.Core.Models;
using FrbsApp.DataParser.Models;
using Microsoft.EntityFrameworkCore;
using System.Formats.Asn1;
using System.Globalization;

IEnumerable<FrbsDataItem> data = new List<FrbsDataItem>();

using (var reader = new StreamReader("Data/forbes_2022_billionaires.csv"))
using (var csv = new CsvReader(reader, new CultureInfo("en")))
{
    data = csv.GetRecords<FrbsDataItem>().ToList();
    var ctx = new FrbsContext();

    //Categories
    /*var categories = data.Select(x => x.category.Trim())
        .Distinct()
        .Where(x => x.Length > 1)
        .ToList();

    ctx.Categories.AddRange(categories.Select(x => new Category { Name = x }));
    ctx.SaveChanges();*/

    //ctx.Categories.RemoveRange(ctx.Categories.ToList());
    //ctx.SaveChanges();

    // Countries

    //Categories

    /*var countries = data.Select(x => x.country.Trim())
        .Distinct()
        .Where(x => x.Length > 1)
        .ToList();

    ctx.Countries.AddRange(countries.Select(x => new Country { Name = x }));
    ctx.SaveChanges();*/

    //ctx.Countries.RemoveRange(ctx.Categories.ToList());
    //ctx.SaveChanges();



    // ctx.Persons.RemoveRange(ctx.Persons.ToList());
    //  ctx.SaveChanges();

    // ctx.Countries.RemoveRange(ctx.Countries.ToList());
    // ctx.SaveChanges();

    // Cities


    /*foreach (var d in data)
    {
        var city = d.city;
        var country = d.country;

        if (ctx.Countries.Include(x => x.Cities).Any(x => x.Name == country && x.Cities.Any(y => y.Name == city)))
            continue;

        var countryEntity = ctx.Countries.FirstOrDefault(x => x.Name == country);
        var cityEntity = new City { Name = city, Country = countryEntity };
        ctx.Cities.Add(cityEntity);
    }

    ctx.SaveChanges();*/



    foreach (var d in data)
    {
        var category = d.category;
        var city = d.city;

        ctx.Persons.Add(new Person
        {
            Name = d.personName,
            Age = d.age,
            BirthDate = d.birthDate,
            FinalWorth = (decimal)d.finalWorth,
            Rank = d.rank,
            Category = ctx.Categories.FirstOrDefault(x => x.Name == category),
            City = ctx.Cities.FirstOrDefault(x => x.Name == city)
        });
        Console.WriteLine("-");
    }


    //ctx.SaveChanges();

    Console.WriteLine("Data Reading Finished"); 
}

