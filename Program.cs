using Calculator2WithXUnitTest;
using System;

namespace Calculator2WithXUnitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculating = true;

            while (continueCalculating)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine(" ");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine(" ");
                Console.WriteLine("Press 5 to Exit the calculator");

                Console.Write("Enter your choice: ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        PerformAddition();
                        break;
                    case 2:
                        PerformSubtraction();
                        break;
                    case 3:
                        PerformMultiplication();
                        break;
                    case 4:
                        PerformDivision();
                        break;
                    case 5:
                        continueCalculating = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void PerformAddition()
        {
            double num1 = GetUserNumber("Enter the first number: ");
            double num2 = GetUserNumber("Enter the second number: ");
            double result = Calc.Addition(num1, num2);
            Console.WriteLine($"Result: {result}");
        }

        static void PerformSubtraction()
        {
            double num1 = GetUserNumber("Enter the first number: ");
            double num2 = GetUserNumber("Enter the second number: ");
            double result = Calc.Subtraction(num1, num2);
            Console.WriteLine($"Result: {result}");
        }

        static void PerformMultiplication()
        {
            double num1 = GetUserNumber("Enter the first number: ");
            double num2 = GetUserNumber("Enter the second number: ");
            double result = Calc.Multiplication(num1, num2);
            Console.WriteLine($"Result: {result}");
        }

        static void PerformDivision()
        {
            double dividend = GetUserNumber("Enter the dividend: ");
            double divisor = GetUserNumber("Enter the divisor: ");
            try
            {
                double result = Calc.Division(dividend, divisor);
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static double GetUserNumber(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                try
                {
                    return double.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}



