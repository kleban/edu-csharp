using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresDemoApp.Models
{
    public class Triangle : Shape
    {
        protected double a;
        protected double b;
        protected double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double S()
        {
            double p = P() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override double P()
        {
            return a + b + c;
        }

        public override string ToString()
        {
            return $"Triangle: p = {P()}, s = {S():0.00}";
        }
    }
}
