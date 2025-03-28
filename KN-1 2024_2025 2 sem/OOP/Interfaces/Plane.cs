using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Plane : Transport, IDrive, IFLy
    {
        public void Drive()
        {
            Console.WriteLine("I can drive slow");
        }

        public void Fly()
        {
            Console.WriteLine("I can fly high");
        }
    }
}
