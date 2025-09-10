using LINQDemo;

// generate dictionary of cars with models and marks
var models_and_marks = new Dictionary<string, List<string>>();

Dictionary<string, List<string>> models = new()
{
    ["Corolla"] = new List<string> { "L", "LE", "SE", "XSE" },
    ["Camry"] = new List<string> { "LE", "SE", "XLE", "TRD" },
    ["Civic"] = new List<string> { "LX", "Sport", "EX", "Touring" },
    ["Accord"] = new List<string> { "LX", "Sport", "EX-L", "Touring" },
    ["Golf"] = new List<string> { "Trendline", "Comfortline", "Highline", "GTI" },
    ["Passat"] = new List<string> { "Trendline", "Comfortline", "Highline", "R-Line" },
    ["Elantra"] = new List<string> { "SE", "SEL", "Limited", "N Line" },
    ["Sonata"] = new List<string> { "SE", "SEL", "Limited", "N Line" }
};

var cars = new List<Car>();

for (int i = 0; i < 100; i++)
{
    var brand = models.Keys.ToList()[new Random(i).Next(0, models.Count())];
    var brand_models = models[brand].ToList();
    cars.Add(new Car
    {
        Mark = brand_models[new Random(i).Next(0, brand_models.Count())],
        Price = new Random().Next(20000, 100000),
        Quantity = new Random().Next(1, 20),
        Brand = brand
    });
}

cars.Take(4).ToList().ForEach(Console.WriteLine);

//

Console.WriteLine("----------");

cars.Where(c => c.Price > 50000 && c.Brand == "Civic").ToList().ForEach(Console.WriteLine);

Console.WriteLine("----------");

cars.GroupBy(c => c.Brand)
    .Select(g => new
    {
        Brand = g.Key,
        TotalQuantity = g.Sum(c => c.Quantity),
        AveragePrice = g.Average(c => c.Price)
    })
    .ToList()
    .ForEach(g => Console.WriteLine($"Brand: {g.Brand}, Total Quantity: {g.TotalQuantity}, Average Price: {g.AveragePrice:f2}"));

Console.WriteLine("----------");

List<CarTotal> grouped_cars = cars.GroupBy(c => c.Brand)
    .Select(g => new CarTotal
    {
        Brand = g.Key,
        Total = g.Sum(c => c.Price * c.Quantity)
    })
    .OrderByDescending(ct => ct.Total)
    .ToList();


   
grouped_cars.ForEach(ct => Console.WriteLine(ct));

foreach (var item in cars.Select(c => c.Brand).Distinct().Where(x=> x.Length > 5))
{
    Console.WriteLine(item);
}

