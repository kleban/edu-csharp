using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemoApp
{
    public class Car : Transport, IDrive
    {
        public Car(string model) : base(model)  { }

        public void Drive()
        {
            Console.WriteLine($"{model}: I can Drive!");
        }
    }
}
