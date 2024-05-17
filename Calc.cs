using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Calculator2WithXUnitTest
{
    public class Calc
    {
        public static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Division(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Error: Cannot divide by zero.");
            }
            return dividend / divisor;
        }
    }
}

