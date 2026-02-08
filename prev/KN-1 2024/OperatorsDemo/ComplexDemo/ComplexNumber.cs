using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexDemo
{
    public class ComplexNumber
    {
        //a + bi
        private double real;
        private double imaginary;

        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public double Real { get { return real; } }
        public double Imaginary { get { return imaginary; } }

        public static ComplexNumber operator+(ComplexNumber cn1, ComplexNumber cn2)
        {
            double realPart = cn1.Real + cn2.Real;
            double imaPart = cn1.Imaginary + cn2.Imaginary;
            return new ComplexNumber(realPart, imaPart);
        }

        public static ComplexNumber operator *(ComplexNumber cn1, ComplexNumber cn2)
        {
            double realPart = cn1.Real * cn2.Real;
            double imaPart = cn1.Imaginary * cn2.Imaginary;
            return new ComplexNumber(realPart, imaPart);
        }

        public override string ToString()
        {
            string str = string.Empty;

            if (real != 0)
            {
                str += $"{real}";
                if(imaginary != 0)                
                    str += $" {(imaginary < 0 ? "-" : "+")} {Math.Abs(imaginary)}i";
            } 
            else
            {
                if (imaginary != 0)                
                    str += $"{(imaginary < 0 ? "-" : "")}{Math.Abs(imaginary)}i";
            }

            return str.Length == 0 ? "0" : str;
        }
    }
}
