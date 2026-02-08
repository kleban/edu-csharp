
using GenericDemo;
using System.Collections;

List<Product> products = ProductsGenerator.Generate(10);

Console.WriteLine("------------ Initial products -------------");
foreach (var product in products)
{
    Console.WriteLine(product);
}
Console.WriteLine(products.Any(p => p.Price > 90));
products.Add(new Product
{
    Name = "New Product",
    Price = 99.99,
    Quantity = 10
});

products.AddRange(ProductsGenerator.Generate(2));
Console.WriteLine("--------------- TOTAL -------------");

products.GroupBy(x=> x.Name).GroupBy(x => x.Key)
    .Select(g => new
    {
        Name = g.Key,
        TotalPrice = g.Sum(p => p.Sum(p => p.Price * p.Quantity))
    })
    .ToList()
    .ForEach(g => Console.WriteLine($"Name: {g.Name}, Total Amount: {g.TotalPrice}"));




Console.WriteLine();
double avg = products.Average(p => p.Price);
Console.WriteLine("Avg price: " + avg);
Console.WriteLine(products.Count(p => p.Price > 50 && p.Quantity > 20));

products.FindAll(p => p.Price > 50 && p.Quantity > 50)
    .ForEach(p => Console.WriteLine(p));

products.Find(x => x.Name == "Smartphone");
products.FirstOrDefault(x => x.Name == "Smartphone");


Console.WriteLine("-----------");

Console.WriteLine("------------ Sorted products -------------");
products = products.OrderByDescending(x => x.Quantity).ThenBy(x=> x.Price).ToList();
foreach (var product in products)
{
    Console.WriteLine(product);
}

products.RemoveAll(p => p.Price > 90);
products.Select(p => $"{p.Price} USD").ToList()
    .ForEach(p => Console.WriteLine(p));
