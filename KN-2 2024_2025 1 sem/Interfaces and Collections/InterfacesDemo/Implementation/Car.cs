using InterfacesDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo.Implementation
{
    public class Car : IDrive, ITransportModel
    {
        public string Model { get; set; }

        public void Drive()
        {
            Console.WriteLine("I can drive!");
        }
    }
}
