using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresDemo.Models
{
    public class Quadrilateral : Figure
    {
        protected double a;
        protected double b;
        protected double c;
        protected double d;
        public Quadrilateral(double a, double b, double c, double d)
        {
            //check
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public override double GetP()
        {
            return a + b + c + d;
        }

        public override double GetS()
        {
            return -1;
        }
    }
}
