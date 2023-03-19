using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleElementsArray
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

        static int[] GetInput()
        {
            Console.WriteLine("Enter three integers:");
            int[] arr = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter integer {0}: ", i + 1);
                arr[i] = GetValidInput();
            }

            return arr;
        }

        static int GetValidInput()
        {
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Invalid input. Enter an integer: ");
            }
            return num;
        }
    }
}
