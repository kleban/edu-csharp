using System;
using System.Collections.Generic;
using System.Text;

namespace FractionsDemo
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public int Numerator { get { return numerator; } }
        public int Denominator { get { return denominator; } }

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            _short();
        }

        private void _short() 
        {
            int gcd = _gcd_euclidean(Math.Abs(numerator), Math.Abs(denominator));
            int sign = denominator < 0 ? -1 : 1; 
            numerator = sign * numerator / gcd;
            denominator = sign * denominator / gcd;
        }

        private int _gcd_euclidean(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }



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
