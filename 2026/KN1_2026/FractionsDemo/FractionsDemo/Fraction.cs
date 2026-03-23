using System;
using System.Collections.Generic;
using System.Text;

namespace FractionsDemo
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            short();
        }

        private void _short() {}

        public static Fraction operator+(Fraction f1, Fraction f2)
        {
            int denom = f1.denominator * f2.denominator;
            int numer = f1.numerator * f2.denominator + f2.numerator * f1.denominator;
            return new Fraction(numer, denom);
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";            
        }
    }
}
