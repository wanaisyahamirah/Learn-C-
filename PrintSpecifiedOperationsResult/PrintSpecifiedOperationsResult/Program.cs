using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSpecifiedOperationsResult
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            int num1 = GetUserInput();
            int num2 = GetUserInput();

            // Call the methods for each operation and print the result
            Console.WriteLine("Sum: " + Add(num1, num2));
            Console.WriteLine("Difference: " + Subtract(num1, num2));
            Console.WriteLine("Product: " + Multiply(num1, num2));
            Console.WriteLine("Quotient: " + Divide(num1, num2));
            Console.WriteLine("Modulus: " + Modulus(num1, num2));

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: division by zero");
                return 0;
            }
            else
            {
                return num1 / num2;
            }
        }

        static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        static int GetUserInput()
        {
            Console.Write("Enter any number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        /* 
         *  Program completed, can improvise by allowing users
         *  to choose which operations to execute
         */

    }
}
