using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calculator = new CalculatorClass();

            int sumTest = calculator.Sum(4, 3);
            Assert.AreEqual(7, sumTest);
        }
    }
}
