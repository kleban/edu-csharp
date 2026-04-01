using UnitTestsDemo;

namespace CalcDemoTests
{
    [TestClass]
    public sealed class CalcTester
    {
        private Calculator _calculator = new Calculator();
        [TestMethod]
        public void TestPlusMethod()
        {
            double sum = _calculator.Plus(10.5, 2.3);
            Assert.AreEqual(12.8, sum, 0.0000000000001);

            sum = _calculator.Plus(10.5, 2.3);
            Assert.AreNotEqual(108, sum, 0.0000000000001);           
        }

        [TestMethod]
        public void TestDivMethod()
        {
            double div = _calculator.Divide(10, 2.5);
            Assert.AreEqual(4.1, div, 0.0000000000001);
        }
    }
}
