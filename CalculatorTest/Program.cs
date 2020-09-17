using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            
            double number1 = AskNumbers();
            double number2 = AskNumbers();
            string operation = AskOperation();
            double result = DoOperation(calculator, number1, number2, operation);
            Print(result);         
        }

        static double AskNumbers()
        {
            double number;
            do
            {
                Console.Write("Enter number: ");
            } while (!double.TryParse(Console.ReadLine(), out number));
            return number;
        }

        static string AskOperation()
        {
            string operation;
            bool validOperations = false;
            do
            {
                Console.WriteLine("Possible operations -,+,*,/," +
                    "\n p- raise a number to a power, " +
                      "\n sqrt- square root  first number, " +
                    "\n r- remainder of the division ");
                Console.Write("Enter operation: ");
                operation = Console.ReadLine();

                string[] massOperations = { "+", "-", "*", "/", "p", "r", "sqrt" };
                for (int i = 0; i < massOperations.Length; i++)
                {
                    if (massOperations[i] == operation)
                    {
                        validOperations = true;
                    }
                }
            } while (validOperations == false);
            return operation;
        }

        static double DoOperation(Calculator calculator, double number1, double number2, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result=calculator.Add(number1, number2);
                    break;
                case "-":
                    result = calculator.Substract(number1, number2);
                    break;
                case "*":
                    result = calculator.Multiply(number1, number2);
                    break;
                case "/":
                    try
                    {
                        result = calculator.Divide(number1, number2);
                        if (number2 == 0)
                        {
                            throw new DivideByZeroException("Sorry, but you can't divide on '0'!");
                        }
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine($"Exeption: {ex.Message}");
                        result = 0;
                    }
                       
                    break;     
                case "p":
                    result = Math.Pow(number1, number2);
                    break;
                case "r":
                    result = number1 % number2;
                    break;
                case "sqrt":
                    try
                    {
                        result = Math.Sqrt(number1);

                        if (number1 < 0)
                        {
                            result = 0;
                            throw new Exception("number < 0");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exeption: {ex.Message}");
                    }
                    break;

                default:
                    break;
            }
            return result;
        }

        static void Print(double result)
        {
            Console.WriteLine($"result= {result}");
        }   
    }
}