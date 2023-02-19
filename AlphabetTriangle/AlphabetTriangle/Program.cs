using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            int num = GetUserInput();
            // Call the method to print the alphabet triangle
            PrintAlphabetTriangle(num);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static int GetUserInput()
        {
            Console.Write("Enter number of rows: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        /*
         In the PrintAlphabetTriangle method, 
         we have used three nested loops to print the spaces, 
         the increasing sequence of letters, and the decreasing sequence of letters. 
         The first loop iterates from 1 to the input num, 
         and the inner loops print the spaces and the letters. 
         The letters are printed by converting the loop variable to a character and 
         adding 64 to get the corresponding uppercase letter (A = 65 in the ASCII table).
         */

        static void PrintAlphabetTriangle(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(j + 64));
                }

                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write((char)(j + 64));
                }

                Console.WriteLine();
            }
        }
    }
}
