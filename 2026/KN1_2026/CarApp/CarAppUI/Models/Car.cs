using System;
using System.Collections.Generic;
using System.Text;

namespace CarAppUI.Models
{
    public class Car
    {
        public string Model { get; set; }
        public string Mark { get; set; }
        public int Year { get; set; }
        public DateTime RegisterDate { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Mark} {Model} ({Year}) - ${Price}";
        }
    }
}
