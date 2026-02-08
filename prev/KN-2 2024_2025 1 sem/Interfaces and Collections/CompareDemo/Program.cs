
using CompareDemo;

var list = new List<Product>();
var r = new Random();

for (int i = 0; i < 10; i++)
{
    list.Add(new Product
    {
        Name = $"Name_{r.Next(1000, 2000)}",
        Price = r.Next(100, 300) + Math.Round(r.NextDouble()),
        Qty = r.Next(1, 100),
        Rating = r.Next(1, 6)
    });
}
Console.WriteLine("Init List");
Print(list);

Console.WriteLine("Sorted by Name List");
list.Sort(new ProductSortByNameComparer());
Print(list);
Console.WriteLine("Sorted by Price List");
list.Sort(new ProductSortByPriceComparer());
Print(list);
Console.WriteLine("Sorted by Rating List");
list.Sort(new ProductSortByRatingComparer());
Print(list);


static void Print(List<Product> list)
{
    Console.WriteLine("-------------------------");
    foreach (var p in list)
    {
        Console.Write($"{p.Name} - ${p.Price:f2} ({p.Qty}) -> ");
        for(int i = 0; i < p.Rating; i++)
            Console.Write("*");
        Console.WriteLine();
    }
    Console.WriteLine();
}