using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresDemoApp.Models
{
    public class Rect : Quad
    {
        public Rect(double a, double b) 
            : base(a, b, a, b)
        {
        }

        public override double P()
        {
            return 2*(a + b);
        }

        public override double S()
        {
            return a*b;
        }
    }
}
