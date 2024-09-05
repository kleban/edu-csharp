using InterfacesDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo.Implementation
{
    public class Plane : IFly, IDrive, ITransportModel
    {
        public string Model { get ; set ; }

        public void Drive()
        {
            Console.WriteLine("I can drive in airport!");
        }

        public void Fly()
        {
            Console.WriteLine("I can fly!");
        }
    }
}
