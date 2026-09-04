using System;
using System.Collections.Generic;
using System.Text;

namespace StringFormatDemo
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        //public override string ToString()
        //{
        //    return string.Format(
        //        "{0,-20} {1,8} {2,15:C}",
        //        Name, Quantity, Price
        //        );
        //}

        public override string ToString()
        {
            return $"{Name,-20} {Quantity,8} {Price,15:C}";
        }
    }
}
