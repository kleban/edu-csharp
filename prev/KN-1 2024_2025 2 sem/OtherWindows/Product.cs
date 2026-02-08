using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherWindows
{
    public class Product
    {
        public string Title { get; set; }
        public double Price { get; set; } = new Random().NextDouble() * 100;
    }
}
