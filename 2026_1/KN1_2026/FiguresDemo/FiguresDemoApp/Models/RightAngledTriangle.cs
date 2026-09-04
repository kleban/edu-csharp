using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresDemoApp.Models
{
    public class RightAngledTriangle : Triangle
    {
        public RightAngledTriangle(double a, double b)
            : base(a, b, Math.Sqrt(a*a + b*b))
        {
            
        }

        public override double S()
        {
            return (a * b) / 2;
        }
    }
}
