using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresDemoApp.Models
{
    public class Quad : Shape
    {
        protected double a;
        protected double b;
        protected double c;
        protected double d;

        public Quad(double a, double b, double c, double d)
        {
            this.a = a; 
            this.b = b;
            this.c = c;
            this.d = d;         
        }

        public override double S()
        {
            return -1;
        }

        public override double P()
        {
            return a + b + c +d;
        }

        public override string ToString()
        {
            return $"Quad: p = {P()}, s = NaN";
        }
    }
}
