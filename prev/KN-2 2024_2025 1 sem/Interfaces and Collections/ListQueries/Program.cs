using ListQueries;

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

//list = list.OrderBy(x => x.Price).OrderBy(x => x.Rating).ToList();
//list = list.Where(x => x.Rating % 2 == 0 && x.Rating > 3).OrderBy(x=> x.Price).ToList();
//Print(list);

var item = list.FirstOrDefault(x => x.Price > 200);

if(item is not null)
{

}

var grouped = list.GroupBy(x => x.Rating);

foreach(var group in grouped)
{
    Console.WriteLine($"{group.Key}:\t{group.Count()}");
}

static void Print(List<Product> list)
{
    Console.WriteLine("-------------------------");
    foreach (var p in list)
    {
        Console.Write($"{p.Name} - ${p.Price:f2} ({p.Qty}) -> ");
        for (int i = 0; i < p.Rating; i++)
            Console.Write("*");
        Console.WriteLine();
    }
    Console.WriteLine();
}