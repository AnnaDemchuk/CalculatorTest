using System;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using CalculatorTest;
using NUnit.Framework.Constraints;

namespace UnitTestProjectMsTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(6,3,2)]
        [TestCase(-6, 1, -6)]
        [TestCase(6.2, 3.1, 2)]
        [TestCase(0, 3, 0)]
        [TestCase(1, 3, 0.33333333333333331d)]
        [TestCase(2, 0, double.PositiveInfinity)]
        [TestCase(0, 0, double.NaN)]

        public void DivideTwoNumbers(double oneNumber, double twoNumber, double expectedResult)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Divide(oneNumber, twoNumber);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(6, 3, 9)]
        [TestCase(-6, 1, -5)]
        [TestCase(6.2, 3.1, 9.3)]
        [TestCase(0, 3, 3)]
        [TestCase(1.3, 3, 4.3)]   
        public void AddTwoNumbers(double oneNumber, double twoNumber, double expectedResult)
        {
            double result = new Calculator().Add(oneNumber, twoNumber);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(7, 3, 4)]
        [TestCase(-6, 1, -7)]
        [TestCase(2, 3, -1)]
        [TestCase(6.3, 3.1, 3.19999999999999991d)]
        [TestCase(3, 0, 3)]
        [TestCase(0, 5, -5)]
       
        public void SubstractTwoNumbers(double oneNumber, double twoNumber, double expectedResult)
        {
            double result = new Calculator().Substract(oneNumber, twoNumber);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(7, 3, 21)]
        [TestCase(-6, 2, -12)]
        [TestCase(2.01, 2.5, 5.0249999999999995d)]
        [TestCase(3, 1, 3)]
        [TestCase(3, 0, 0)]
        [TestCase(0, 0, 0)]

        public void MultiplyTwoNumbers(double oneNumber, double twoNumber, double expectedResult)
        {
            double result = new Calculator().Multiply(oneNumber, twoNumber);
            Assert.AreEqual(expectedResult, result);
        }

        [OneTimeSetUp]
        public void OpenCalculator()
        {
            Console.WriteLine("Open calculator");
        }

    }

}
