namespace MathLib
{
    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        public Fraction(int num, int denom)
        {
            _denominator = denom;
            _numerator = num;
        }

        public int Numerator { get { return _numerator; } }
        public int Denumerator { get { return _denominator; } }
        public static Fraction operator+(Fraction f1, Fraction f2)
        {
            return new Fraction(
                f1._numerator*f2._denominator + f2._numerator*f1._denominator, 
                f1._denominator * f2._denominator);
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }
    }
}
