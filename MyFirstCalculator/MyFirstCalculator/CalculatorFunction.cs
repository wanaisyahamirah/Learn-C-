using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCalculator
{
    public class CalculatorFunction
    {
        public double FindSummation(double num1, double num2)
        {
            return num1 + num2;
        }

        public double FindDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        public double FindMultiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public double FindDivision(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
