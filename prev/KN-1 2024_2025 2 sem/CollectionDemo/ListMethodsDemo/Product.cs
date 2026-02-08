using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethodsDemo
{
    public class SimpleProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Price:C}";
        }
    }
    
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public override string ToString()
        {
            return $"{Name}, {Price:C}, {Quantity} pcs";
        }
    }
}
