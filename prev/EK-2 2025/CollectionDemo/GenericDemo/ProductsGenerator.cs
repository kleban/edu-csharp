using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class ProductsGenerator
    {
        private static string[] product_names = new string[]
        {
            "Laptop", "Smartphone", "Tablet", "Headphones", "Smartwatch",
            "Camera", "Printer", "Monitor", "Keyboard", "Mouse"
        };
        public static List<Product> Generate(int count = 10)
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < count; i++)
            {
                products.Add(new Product
                {
                    Name = product_names[new Random().Next(0, product_names.Length)],
                    Price = Math.Round(new Random().NextDouble() * 100, 2),
                    Quantity = new Random().Next(1, 100)
                });
            }
            return products;
        }
    }
}
