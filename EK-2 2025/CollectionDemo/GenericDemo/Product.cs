using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Price: ${Price}, Quantity: {Quantity}";
        }
    }
}
