using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo
{
   public class ShortProduct
    {
        public string Name { get; set; }
        public double PriceInUsd { get; set; }
        public double PriceInUah { get { return PriceInUsd * 44.44; }  }
        public override string ToString()
        {
            return $"Short: {Name}: ${PriceInUsd:0.00}";
        }
    }
}
