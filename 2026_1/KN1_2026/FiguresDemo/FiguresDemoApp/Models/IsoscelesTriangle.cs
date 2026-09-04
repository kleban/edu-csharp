using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresDemoApp.Models
{
    public class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double a_isosceles, double b)
            : base(a_isosceles, a_isosceles, b) { }

        public override double P()
        {
            return a * 2 + c;
        }
        public override string ToString()
        {
            return $"IsoscelesTriangle: p = {P()}, s = {S():0.00}";
        }
    }
}
