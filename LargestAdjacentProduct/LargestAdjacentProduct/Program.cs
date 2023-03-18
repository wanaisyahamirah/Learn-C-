using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestAdjacentProduct
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
            Console.Write("Enter the elements of the array (comma-separated): ");
            string[] input = Console.ReadLine().Split(',');
            int[] nums = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }
            return nums;
        }
    }
}
