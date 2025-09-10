

using ListExtensionDemo;
using System;
using System.Collections.Generic;

Random r = new Random();

List<Product> products = new List<Product>();

for(int i = 0; i < 10 ; i++)
{
    products.Add(new Product
    {
        Name = $"Product {i + 1}",
        Price = r.Next(100, 1000),
        Quantity = r.Next(1, 20)
    });
}

foreach (var product in products)
{
    Console.WriteLine(product.GetInfo());
}
