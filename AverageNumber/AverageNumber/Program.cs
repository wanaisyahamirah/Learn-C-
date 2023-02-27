using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
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

        static double CalculateAverage(int[] numbers)
        {
            double sum = num1 + num2 + num3 + num4;
            double average = sum / 4;
            return average;
        }

        static int[] GetIntegerUserInput()
        {
            int[] numbers = new int[4];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numbers;
        }
    }
}
