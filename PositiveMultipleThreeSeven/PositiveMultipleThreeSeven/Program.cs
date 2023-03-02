using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveMultipleThreeSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            
            // Get user input
            Console.Write("Enter a positive number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is a multiple of 3 or 7
            bool isMultipleOf3 = IsMultipleOf3(number);
            bool isMultipleOf7 = IsMultipleOf7(number);

            // Print the result
            PrintResult(number, isMultipleOf3, isMultipleOf7);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static int GetPositiveNumber()
        {
            int number = 0;
            bool validInput = false;
            while (!validInput)
            {
                Console.Write("Enter a positive number: ");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Number must be positive. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                }
            }
            return number;
        }

        static bool IsMultipleOf3(int number)
        {
            return number % 3 == 0;
        }

        static bool IsMultipleOf7(int number)
        {
            return number % 7 == 0;
        }

        static void PrintResult(int number, bool isMultipleOf3, bool isMultipleOf7)
        {
            if (isMultipleOf3)
            {
                Console.WriteLine("{0} is a multiple of 3.", number);
            }
            else if (isMultipleOf7)
            {
                Console.WriteLine("{0} is a multiple of 7.", number);
            }
            else
            {
                Console.WriteLine("{0} is not a multiple of 3 or 7.", number);
            }
        }
    }
}
