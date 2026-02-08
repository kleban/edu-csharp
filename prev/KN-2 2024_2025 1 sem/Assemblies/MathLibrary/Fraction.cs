namespace MathLibrary
{
    public class Fraction
    {
        private int a;
        private int b;

        public Fraction() : this(1, 1) { }
        public Fraction(int a, int b)
        {
            this.a = a; this.b = b;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.a * f2.b + f1.b * f1.a, f2.b * f1.b);
        }

        public override string ToString()
        {
            return $"{a}/{b}";
        }

    }
}
