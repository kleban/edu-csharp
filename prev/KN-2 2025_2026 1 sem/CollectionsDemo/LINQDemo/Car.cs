using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    internal class Car
    {
        public string Mark { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public string Brand { get; set; }

        public override string ToString()
        {
            return $"Car Mark: {Mark}, Price: {Price:f2}, Quantity: {Quantity:f2}, Brand: {Brand}";
        }
    }
}
