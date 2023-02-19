using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTriangle
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

        static void PrintNumberTriangle(int numRows)
        {
            for (int i = 1; i <= numRows; i++)
            {
                PrintSpaces(numRows - i);
                PrintAscendingNumbers(i);
                PrintDescendingNumbers(i - 1);
                Console.WriteLine();
            }
        }

        static void PrintSpaces(int numSpaces)
        {
            for (int i = 0; i < numSpaces; i++)
            {
                Console.Write(" ");
            }
        }

        static void PrintAscendingNumbers(int num)
        {
            for(int i = 1; i <= num; i++)
            {
                Console.Write(i);
            }
        }

        static void PrintDescendingNumbers(int num)
        {
        }
}
