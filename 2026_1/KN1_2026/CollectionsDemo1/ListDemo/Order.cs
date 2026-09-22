using System;
using System.Collections.Generic;
using System.Text;

namespace ListDemo
{
    public class Order 
    {
        public string ClientName { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public bool IsComplete { get; set; }
    }
}
