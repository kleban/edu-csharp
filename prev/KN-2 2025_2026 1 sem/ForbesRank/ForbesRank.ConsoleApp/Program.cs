
using CsvHelper;
using ForbesRank.ConsoleApp.Model;
using ForbesRank.Domain;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

IEnumerable<ForbsDataItem> data = new List<ForbsDataItem>();

using (var reader = new StreamReader("data/forbes_2022_billionaires.csv"))
using (var csv = new CsvReader(reader, new CultureInfo("en")))
{
    data = csv.GetRecords<ForbsDataItem>().ToList();
}

var categories = data.Select(x => x.category).Distinct().OrderBy(x => x).ToList();

ForbesConrext db = new ForbesConrext();

//foreach (var category in categories)
// db.Categories.Add(new Category { Name = category });

//var countries = data.Select(x => x.country).Distinct().OrderBy(x => x).ToList();
//db.Countries.AddRange(countries.Select(x=> new Country { Name = x }));

//db.Categories.Add(new Category { Name = category });



foreach (var d in data)
{
    var category = d.category;
    var city = d.city;

    db.People.Add(new Person
    {
        Name = d.personName,
        Age = d.age,
        BirthDate = d.birthDate,
        FinalWorth = d.finalWorth,
        Rank = d.rank,
        Category = db.Categories.FirstOrDefault(x => x.Name == category),
        City = db.Cities.FirstOrDefault(x => x.Name == city)
    });
    Console.WriteLine("-");
}


db.SaveChanges();

