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
            Console.WriteLine("a: " + inputNumber1);
            Console.WriteLine("b: " + inputNumber2);
        }

        static void SwapTheNumbers(int inputNumber1, int inputNumber2)
        {
            // Add the two numbers a and b and store the result in a
            inputNumber1 = inputNumber1 + inputNumber2;

            // Subtract b from the new value of a and store the result in b
            inputNumber2 = inputNumber1 - inputNumber2;

            // Subtract the original value of b from the new value of a and store the result in a

            // Print the values of a and b after swapping

            // Exit the program

        }
    }
}
