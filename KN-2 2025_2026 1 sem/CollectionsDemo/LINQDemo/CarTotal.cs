using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    internal class CarTotal
    {
        public string Brand { get; set; }
        public double Total { get; set; }
        public override string ToString()
        {
            return $"Brand: {Brand}, Total: {Total:f2}";
        }
    }
}
