using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresDemo
{
    public class Rectangle : Quad
    {
        public Rectangle(double a, double b)
            : base(a, b, a, b)
        {
            Console.WriteLine(typeof(Rectangle));
        }

        public override double S()
        {
            return a * b;
        }

        public override double P()
        {
            return (a + b) * 2;
        }
    }
}
