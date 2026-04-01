using PadDemo;

var list = new Product[3]
{
    new Product {Name = "short", Price = 2334.33},
    new Product {Name = "long product title", Price = 3.11},
    new Product {Name = "avg title", Price = 0.33}
};

foreach (var item in list)
    Console.WriteLine(item);


