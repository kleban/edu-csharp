using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Ship : Transport, ISwim
    {
        public void Swim()
        {
            Console.WriteLine("I can swim");
        }
    }
}
