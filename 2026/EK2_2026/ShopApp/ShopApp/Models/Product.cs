using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Models
{
    public class Product
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }
        public double StockQuantity { get; set; }
    }
}
