using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumberApp
{
    public class ComplexNumber
    {
        private double real;
        private double imaginary;

        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }

        public override string ToString()
        {
            string str = "";
            if (real != 0)            
                str += real;
            if (imaginary != 0)
            {
                if (imaginary > 0 && real != 0)
                    str += "+";
                str += imaginary + "i";
            }
            
            return str;
        }
    }
}
