using System;
using System.Collections.Generic;
using System.Text;

namespace ListDemo
{
    //IComparable
    //IComparer
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public int CompareTo(Product? other)
        {
            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"{Name}, {Price} UAH - Qty: {Quantity} items";
        }
    }
}
