using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public class Plane : Transport, IFly, IDrive
    {
        public Plane(string model): base(model)
        {
            
        }
        public void Drive()
        {
            Console.WriteLine($"{model}: I can drive!");
        }

        public void Fly()
        {
            Console.WriteLine($"{model}: I can fly!");
        }
    }
}
