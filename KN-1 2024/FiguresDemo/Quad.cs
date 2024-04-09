using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresDemo
{
    public class Quad : Figure
    {
        protected double a = 0;
        protected double b = 0;
        protected double c = 0;
        protected double d = 0;

        public Quad(double a, double b, double c, double d)
        {
            this.a = a; 
            this.b = b;
            this.c = c;
            this.d = d;
            Console.WriteLine(typeof(Quad));
        }

        public override double P()
        {
            return a + b + c + d;
        }

        public override double S()
        {
            return -1;
        }
    }
}
