using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWordInString
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            string aString = GetInput();

            string longestWord = FindLongestWord(aString);

            PrintResult(longestWord);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static String GetInput()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            return input;
        }

        static string FindLongestWord(string input)
        {
            string[] words = input.Split(' '); // Split the string into words
            string longestWord = "";
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            return longestWord;
        }

        static void PrintResult(String longest)
        {
            Console.WriteLine($"The longest word in the string is '{longest}'.");
        }
    }
}
