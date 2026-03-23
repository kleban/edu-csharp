using PadDemo;

var list = new Product[3]
{
    new Product {Name = "Short", Price = 2334.33},
    new Product {Name = "Long product title", Price = 3.11},
    new Product {Name = "Avg title", Price = 0.33}
};

foreach (var item in list)
    Console.WriteLine(item);


