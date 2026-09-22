using MathLib;

namespace AssemblyTest
{
    [TestClass]
    public sealed class FractionTestClass
    {
        [TestMethod]
        public void CtorTestMethod()
        {
            var f = new Fraction(4, 6);
            Assert.AreEqual(4, f.Numerator);
            Assert.AreEqual(6, f.Denumerator);
        }

        [TestMethod]
        public void PlusTestMethod()
        {
            var f1 = new Fraction(1, 2);
            var f2 = new Fraction(1, 3);
            var f3 = f1+f2;
            Assert.AreEqual(5, f3.Numerator);
            Assert.AreEqual(6, f3.Denumerator);
        }
    }
}
