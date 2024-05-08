
using LocalitiesApp.Classes;

Village v1 = new Village { Name = "Progres" };
City c1 = new City { Name = "Ostroh", IsBig = false };
Region r = new Region
{
    Name = "Rivne region",
    Localities = new Locality[2] { v1, c1 }
};

Country country = new Country
{
    Name = "Ukraine",
    CountryCode = "UA",
    Population = 30000000,
    Regions = new[] { r }
};

Console.WriteLine(country.Regions[0].Localities[1].Name);
