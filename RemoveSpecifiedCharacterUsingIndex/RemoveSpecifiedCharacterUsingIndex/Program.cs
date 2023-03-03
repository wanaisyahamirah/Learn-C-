using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveSpecifiedCharacterUsingIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            
            // Get user input
            string inputString = GetUserInput("Enter a string: ");
            int charIndex = GetPositiveNumber("Enter the index of the character to remove: ");

            // Remove character by index
            string outputString = RemoveCharByIndex(inputString, charIndex);

            // Print the result
            PrintResult(outputString);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static string GetUserInput(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be empty!");
                Console.Write(message);
                input = Console.ReadLine();
            }

            return input;
        }

        static int GetPositiveNumber(string message)
        {
            Console.Write(message);
            int number;

            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("Input must be a positive integer!");
                Console.Write(message);
            }

            return number;
        }

        static string RemoveCharByIndex(string input, int index)
        {
            if (index < 0 || index >= input.Length)
            {
                Console.WriteLine("Index is out of range!");
                return input;
            }

            return input.Remove(index, 1);
        }

        static void PrintResult(string output)
        {
            Console.WriteLine("Output string: {0}", output);
        }

    }
}
