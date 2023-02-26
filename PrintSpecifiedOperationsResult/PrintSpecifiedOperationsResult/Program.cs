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
            Console.WriteLine("Hello World!");
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
            return num1 / num2;
        }

        static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        static int GetUserInput()
        {
            Console.Write("Enter number of rows: ");
            return Convert.ToInt32(Console.ReadLine());
        }

    }
}
