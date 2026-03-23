using System;
using System.Collections.Generic;
using System.Text;

namespace PadDemo
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{Name.PadRight(20)} {Math.Round(Price, 2).ToString().PadLeft(8)} UAH";
        }
    }
}
