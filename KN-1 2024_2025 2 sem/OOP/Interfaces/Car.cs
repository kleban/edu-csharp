using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Car : Transport, IDrive
    {
        public void Drive()
        {
            Console.WriteLine("I can drive fast");
        }
    }
}
