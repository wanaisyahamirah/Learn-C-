using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRectangleNumberInput
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

        static int GetInput()
        {
            Console.Write("Enter a single digit number: ");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num) || num < 0 || num > 9)
            {
                Console.Write("Invalid input. Enter a single digit number: ");
            }
            return num;
        }

        static string CreateRectangle(int num)
        {
            string rectangle = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rectangle += num.ToString();
                }
                rectangle += "\n";
            }
            return rectangle;
        }

        static void PrintResult(string rectangle)
        {
            Console.WriteLine(rectangle);
        }
    }
}
