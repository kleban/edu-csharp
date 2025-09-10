namespace MathLibrary
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            this.numerator = numerator;
            this.denominator = denominator;
            Simplify();
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int newNumerator = a.numerator * b.denominator + b.numerator * a.denominator;
            int newDenominator = a.denominator * b.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        private void Simplify()
        {
            if (denominator == 0)
                throw new DivideByZeroException("Denominator cannot be zero.");

            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            numerator /= gcd;
            denominator /= gcd;

            // Keep denominator positive
            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
    }
}
