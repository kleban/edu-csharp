using System;
using System.Collections.Generic;
using System.Text;

namespace ListDemo
{
    public class ShortOrder
    {
        public double TotalPrice { get; set; }
        public bool IsComplete { get; set; }

        public override string ToString()
        {
            return $"{TotalPrice} - {IsComplete}";
        }
    }
}
