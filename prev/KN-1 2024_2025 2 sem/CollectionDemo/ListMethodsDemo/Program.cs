
using ListMethodsDemo;
using System.Threading.Channels;

var fruits = ProductsGenerator.GenerateProducts(10);
fruits.ForEach(Console.WriteLine);

//Console.WriteLine(fruits.Count(x=> x.Quantity > 20 && x.Price > 20));
/*var f1 = fruits.First(x=> x.Price > 200);
var f2 = fruits.FirstOrDefault(x => x.Price > 200);

if (f2 is not null)
    var d = f2.Price;*/

/*
var groupedFruits = fruits.GroupBy(x => x.Name).ToList();

foreach (var group in groupedFruits)
{    
    Console.WriteLine($"Product: {group.Key}, Price: {group.Average(x=> x.Price):C}");
}*/
Console.WriteLine("-------------");
fruits.OrderByDescending(x => x.Price).ToList().ForEach(Console.WriteLine);
Console.WriteLine("-------------");
fruits.Where(x => x.Price > 20 && x.Quantity > 10)
    .OrderByDescending(x => x.Price)
    .ThenBy(x => x.Name)
    .ToList()
    .ForEach(Console.WriteLine);
Console.WriteLine("------------");
fruits.Select(x=> new SimpleProduct { Name = x.Name, Price = x.Price }).ToList().ForEach(Console.WriteLine);