using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCalculator
{
    public class CalculatorFunction
    {
        public static double FindSummation(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double FindDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double FindMultiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double FindDivision(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
