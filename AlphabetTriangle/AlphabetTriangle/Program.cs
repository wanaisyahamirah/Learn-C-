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

            int num = 10;
            // Call the method to print the alphabet triangle
            PrintAlphabetTriangle(num);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

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
