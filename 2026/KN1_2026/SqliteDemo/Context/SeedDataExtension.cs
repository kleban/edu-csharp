using Microsoft.EntityFrameworkCore;
using SqliteDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqliteDemo.Context
{
    public static class SeedDataExtension
    {
        public static ModelBuilder Seed(this ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Category 1" },
                new Category { Id = 2, Name = "Category 2" }
            );

            builder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, Name = "pRODUCT 1", Price = 12.2, Quantity = 100 },
                new Product { Id = 2, CategoryId = 1, Name = "Product 2", Price = 332, Quantity = 200 }
            );

            return builder;
        }
    }
}
