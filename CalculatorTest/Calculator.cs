using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    public class Calculator
    {
        public double Divide(double number1, double number2)
        {
            double result = number1 / number2;
            return result;
        }

        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Substract(double number1, double number2)
        {
            return number1 - number2;
        }

        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}
