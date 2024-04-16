using ComplexDemo;

namespace OperatorsTests
{
    [TestClass]
    public class ComplexNumberTest
    {
        [TestMethod]
        public void PlusTest()
        {
            var c1 = new ComplexNumber(1, 2);
            var c2 = new ComplexNumber(2, -2);

            var result = c1 + c2;

            Assert.AreEqual(3, result.Real);
            Assert.AreEqual(0, result.Imaginary);
        }

        [TestMethod]
        public void ToStringTest()
        {
            // 2 - 2i
            var c = new ComplexNumber(2, -2);
            Assert.AreEqual("2 - 2i", c.ToString());

            //4 + 0i
            c = new ComplexNumber(4, 0);
            Assert.AreEqual("4", c.ToString());

            //0 + 2i
            c = new ComplexNumber(0, 2);
            Assert.AreEqual("2i", c.ToString());

            //0 - 3i
            c = new ComplexNumber(0, -3);
            Assert.AreEqual("-3i", c.ToString());

            //0 - 0i
            c = new ComplexNumber(0, 0);
            Assert.AreEqual("0", c.ToString());

        }
    }
}