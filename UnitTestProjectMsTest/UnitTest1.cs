using System;
using NUnit.Framework;
using CalculatorTest;
using NUnit.Framework.Constraints;

namespace UnitTestProjectMsTest
{
    [TestFixture]
    public class UnitTest1
    {
        
        [Test]
        public void DivideTwoNumbers()
        {
            Calculator calculator = new Calculator();
            double result = calculator.Divide(6, 3);
            Assert.AreEqual(2, result);
        } 
    }
}
