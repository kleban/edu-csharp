using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareDemo
{
    internal class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Qty { get; set; }
        public int Rating { get; set; }
        public int CompareTo(Product? other)
        {
            if(Rating > other.Rating) return 1;
            if(Rating < other.Rating) return -1; 

            return 0;
        }
    }
}
