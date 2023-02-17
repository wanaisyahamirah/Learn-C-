using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static void GetTwoUserInputs()
        {
            int firstNumber, secondNumber;
            Console.Write("Enter the first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First number: " + firstNumber);
            Console.WriteLine("Second number: " + secondNumber);
        }

        static void PrintInputValues(int inputNumber1, int inputNumber2)
        {
            
        }
    }
}
