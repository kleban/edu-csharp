using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo
{
    public class DataGenerator
    {
        public static List<Product> GenerateProducts()
        {
            return new List<Product>
{
    new Product { Id = 1, Name = "Milk", Category = "Dairy", Price = 1.99, ExpiryDate = DateTime.Now.AddDays(7) },
    new Product { Id = 2, Name = "Cheese", Category = "Dairy", Price = 4.99, ExpiryDate = DateTime.Now.AddDays(30) },
    new Product { Id = 3, Name = "Butter", Category = "Dairy", Price = 2.99, ExpiryDate = DateTime.Now.AddDays(20) },
    new Product { Id = 4, Name = "Yogurt", Category = "Dairy", Price = 1.49, ExpiryDate = DateTime.Now.AddDays(10) },

    new Product { Id = 5, Name = "Bread", Category = "Bakery", Price = 2.49, ExpiryDate = DateTime.Now.AddDays(3) },
    new Product { Id = 6, Name = "Croissant", Category = "Bakery", Price = 1.29, ExpiryDate = DateTime.Now.AddDays(2) },
    new Product { Id = 7, Name = "Baguette", Category = "Bakery", Price = 1.99, ExpiryDate = DateTime.Now.AddDays(1) },

    new Product { Id = 8, Name = "Eggs", Category = "Protein", Price = 3.99, ExpiryDate = DateTime.Now.AddDays(14) },
    new Product { Id = 9, Name = "Chicken Breast", Category = "Meat", Price = 6.99, ExpiryDate = DateTime.Now.AddDays(5) },
    new Product { Id = 10, Name = "Beef Steak", Category = "Meat", Price = 12.99, ExpiryDate = DateTime.Now.AddDays(4) },

    new Product { Id = 11, Name = "Apple", Category = "Fruit", Price = 0.79, ExpiryDate = DateTime.Now.AddDays(12) },
    new Product { Id = 12, Name = "Banana", Category = "Fruit", Price = 0.59, ExpiryDate = DateTime.Now.AddDays(6) },
    new Product { Id = 13, Name = "Orange", Category = "Fruit", Price = 0.89, ExpiryDate = DateTime.Now.AddDays(15) },

    new Product { Id = 14, Name = "Carrot", Category = "Vegetable", Price = 0.49, ExpiryDate = DateTime.Now.AddDays(18) },
    new Product { Id = 15, Name = "Potato", Category = "Vegetable", Price = 0.39, ExpiryDate = DateTime.Now.AddDays(25) }
};
        }
    }
}
