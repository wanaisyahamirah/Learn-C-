using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveVowelsInString
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

        static String GetInput()
        {
            // Get user input
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            return input;
        }

        static string RemoveVowels(string input)
        {
            string vowels = "aeiouAEIOU";
            string result = "";
            foreach (char c in input)
            {
                if (!vowels.Contains(c))
                {
                    result += c;
                }
            }
            return result;
        }

        static void PrintResult(String removedVowels)
        {
            // Print result
            Console.WriteLine($"Result: {result}");
        }

    }
}
