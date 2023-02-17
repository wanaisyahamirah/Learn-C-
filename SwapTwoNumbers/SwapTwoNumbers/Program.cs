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

            int firstNumber, secondNumber;

            // Get user inputs
            GetTwoUserInputs(out firstNumber, out secondNumber);

            // Print original values
            Console.WriteLine("Original values:");
            PrintInputValues(firstNumber, secondNumber);

            // Swap the numbers
            SwapTheNumbers(ref firstNumber, ref secondNumber);

            // Print swapped values
            Console.WriteLine("Swapped values:");
            PrintOutputValues(firstNumber, secondNumber);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static void GetTwoUserInputs(out int firstNumber, out int secondNumber)
        {
            Console.Write("Enter the first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
        }

        static void PrintInputValues(int inputNumber1, int inputNumber2)
        {
            Console.WriteLine("a: " + inputNumber1);
            Console.WriteLine("b: " + inputNumber2);
        }

        static void SwapTheNumbers(ref int a, ref int b)
        {
            // Add the two numbers a and b and store the result in a
            a = a + b;

            // Subtract b from the new value of a and store the result in b
            b = a - b;

            // Subtract the original value of b from the new value of a and store the result in a
            a = a - b;
        }

        static void PrintOutputValues(int a, int b)
        {
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
        }

        /*
         In the updated version of the program, 
         the Main method calls the GetTwoUserInputs method to get the user inputs, 
         then prints the original values using the PrintInputValues method. 
         It then calls the SwapTheNumbers method to swap the numbers and 
         finally prints the swapped values using the PrintOutputValues method. 
         All the methods have been maintained, 
         and the SwapTheNumbers method now uses ref parameters to swap the values.
                   
         In C#, out and ref are keywords used to pass arguments to a method by reference, rather than by value.
         ref and out allow a method to modify the original value of a variable passed as an argument, rather than a copy of that value.
         The difference between ref and out is that ref requires the variable to be initialized before it is passed to the method, 
         while out does not. When using out, the method must set a value for the variable before it returns.
        */
    }
}
