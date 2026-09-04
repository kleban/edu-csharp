using StringFormatDemo;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine(
  "{0,-20} {1,8} {2,15:C}",
  "Назва", "Кількість", "Ціна"
);

var list = new Product[3]
{
    new Product {Name = "Short", Price = 2334.33, Quantity = 3},
    new Product {Name = "Long product title", Price = 3.11, Quantity = 450},
    new Product {Name = "Avg title", Price = 0.33, Quantity = 1452}
};

foreach (var item in list)
    Console.WriteLine(item);
