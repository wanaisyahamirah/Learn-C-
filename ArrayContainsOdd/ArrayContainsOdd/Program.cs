using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayContainsOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            
            // Get user input
            int[] array = GetArrayInput();

            // Check if the array contains an odd number
            bool containsOddNumber = ContainsOddNumber(array);

            // Print the result
            PrintResult(containsOddNumber);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static int[] GetArrayInput()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            return array;
        }

        static bool ContainsOddNumber(int[] array)
        {
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }

        static void PrintResult(bool containsOddNumber)
        {
            if (containsOddNumber)
            {
                Console.WriteLine("The array contains an odd number.");
            }
            else
            {
                Console.WriteLine("The array does not contain an odd number.");
            }
        }
    }
}
