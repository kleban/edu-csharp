using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestsDemo
{
    public class Calculator
    {
        public double Plus(double a, double b)
        {
            return a + b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Не можна ділити на нуль");
            return Math.Round(a / b, 2);
        }
    }
}
