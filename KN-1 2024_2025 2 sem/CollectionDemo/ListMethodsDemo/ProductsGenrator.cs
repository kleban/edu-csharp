using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethodsDemo
{
    internal class ProductsGenerator
    {
        static string[] products = { "Apple", "Banana", "Orange", "Grapes", "Mango" };
        static Random random = new Random(1);
        public static List<Product> GenerateProducts(int count)
        {
            List<Product> productsList = new List<Product>();
            for (int i = 0; i < count; i++)
            {
                string name = products[random.Next(products.Length)];
                double price = Math.Round(random.NextDouble() * 100, 2);
                int quantity = random.Next(1, 101);
                productsList.Add(new Product(name, price, quantity));
            }
            return productsList;
        }
    }
}
