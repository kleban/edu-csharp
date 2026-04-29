
using CollectionsDemo;

var list = DataGenerator.GenerateProducts();

//var grouped = list.GroupBy(x => x.Category);

//foreach (var group in grouped)
//{
//    Console.WriteLine($"----{group.Key}");
//    foreach (var product in group)
//    {
//        Console.WriteLine($"\t{product}");
//    }
//}

Console.WriteLine("Order by Expiry Date");
list = list.OrderBy(x => x.Name).ToList();
list.ForEach(Console.WriteLine);

Console.WriteLine("\nShort products");
var shortProducts = list.Skip(10).Select(x =>
                        new ShortProduct
                        {
                            Name = x.Name,
                            PriceInUsd = x.Price
                        }).ToList();

shortProducts.ForEach(Console.WriteLine);

//list.Select(x => x.Price).Average();
Console.WriteLine("\nRight Join Sample");
list.RightJoin(shortProducts, x => x.Name, y => y.Name, 
    (x, y) => new { x.Name, x.Price, y.PriceInUah })
    .ToList()
    .ForEach(x => Console.WriteLine($"{x.Name}: {x.Price} - {x.PriceInUah}"));

list.Where(x => x.Price > 0 && x.Category == "Bread");


//var list = DataGenerator.GenerateProducts();
//var product = new Product
//{
//    Id = 6,
//    Name = "Yogurt",
//    Price = -0.99,
//    ExpiryDate = DateTime.Now.AddDays(10)
//};

//list.Add(product);
//list.Insert(5, new Product
//{
//    Id = 7,
//    Name = "Juice",
//    Price = -3.49,
//    ExpiryDate = DateTime.Now.AddDays(15)
//});

////list.Remove(product);
////list.RemoveAt(0);

//if (!list.Contains(product))
//{
//    list.Add(product);
//    Console.WriteLine("Product added");
//}

////list.AddRange(list);
//if (list.All(x => x.Price < 0))
//{
//    Console.WriteLine("ALL < 0");
//}

//if (list.Any(x => x.Price < 0))
//{
//    Console.WriteLine("ANY  < 0");
//}

//list.Average(x => x.Price);
//Console.WriteLine($"Total products count: {list.Count}");

//list.ForEach(Console.WriteLine);

//var listCount = list.Count(x => x.ExpiryDate >= new DateTime(2026, 5, 15));
//Console.WriteLine($"Expiry Date > 01/06/26: {listCount}");

//list.Find(x => x.Name == "Bread");
//list.FindAll(x => x.Price < 0);
//var p = list.First(x => x.Id == 4)

////list2.ForEach(Console.WriteLine);

