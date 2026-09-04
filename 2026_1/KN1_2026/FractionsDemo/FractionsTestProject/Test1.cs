using FractionsDemo;

namespace FractionsTestProject
{
    [TestClass]
    public sealed class FractionTest
    {
        [TestMethod]
        public void ShortenTestMethod()
        {
            var f = new Fraction(5, 10);
            Assert.AreEqual(1, f.Numerator);
            Assert.AreEqual(2, f.Denominator);

            f = new Fraction(12, 16);
            Assert.AreEqual(3, f.Numerator);
            Assert.AreEqual(4, f.Denominator);
        }

        [TestMethod]
        public void PlusTestMethod()
        {
            var f1 = new Fraction(1, 2);
            var f2 = new Fraction(1, 4);
            var f3 = f1 + f2;

            Assert.AreEqual(3, f3.Numerator);
            Assert.AreEqual(4, f3.Denominator);
        }

        [TestMethod]
        public void ToStringTestMethod()
        {
            var f = new Fraction(2, -4);
            Assert.AreEqual("-1/2", f.ToString());
            f = new Fraction(-1, 2);
            Assert.AreEqual("-1/2", f.ToString());

        }
    }
}
