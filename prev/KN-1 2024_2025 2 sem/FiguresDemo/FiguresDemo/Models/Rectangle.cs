using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresDemo.Models
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(double a, double b)
            : base(a, b, a, b)
        {
        }

        public override double GetP()
        {
            return (a + b) * 2;
        }

        public override double GetS()
        {
            return a * b;
        }
    }
}
