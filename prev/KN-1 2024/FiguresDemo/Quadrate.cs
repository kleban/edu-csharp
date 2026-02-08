using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresDemo
{
    public class Quadrate : Rectangle
    {
        public Quadrate(double a) : base(a,a) 
        {
            Console.WriteLine(typeof(Quadrate));
        }
    }
}
