
using ListDemo;

List<Product> list = new List<Product>
{
    new Product { Name = "Milk", Price = 50, Quantity = 10 },
    new Product {Name = "IPhone", Price = 78000, Quantity = 13},
    new Product {Name = "Table", Price = 3200, Quantity=8}
};

//list.Sort(new ProductPriceComparer());
//list.Reverse();
list.Select(x => x.Name).ToList();
list = list.Where(x=> x.Name.Contains("l")).ToList();
Console.WriteLine(string.Join("\n", list.OrderByDescending(x=> x.Price)));
