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
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static int GetPositiveNumber()
        {
            Console.Write("Enter a positive number: ");
            int number = Convert.ToInt32(Console.ReadLine());
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
    }
}
