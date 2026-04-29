using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Category { get; set; }
        public override string ToString()
        {
            return $"{Name} - ${Price:0.00} ({ExpiryDate.ToString("dd/MM/yy")})";
        }
    }
}
