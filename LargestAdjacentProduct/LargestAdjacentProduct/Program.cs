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

        static int GetTarget()
        {
            Console.Write("Enter the target value: ");
            int target = int.Parse(Console.ReadLine());
            return target;
        }

        static int[] FindLargestAdjacentProduct(int[] nums, int target)
        {
            int[] result = null;
            int largestProduct = int.MinValue;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int product = nums[i] * nums[i + 1];
                if (product == target)
                {
                    result = new int[] { nums[i], nums[i + 1] };
                    break;
                }
                else if (product > largestProduct)
                {
                    largestProduct = product;
                    result = new int[] { nums[i], nums[i + 1] };
                }
            }
            return result;
        }

        static void PrintResult(int[] result)
        {
            if (result == null)
            {
                Console.WriteLine("No pair of adjacent elements in the array has a product equal to the target value.");
            }
            else
            {
                Console.WriteLine($"The pair of adjacent elements ({result[0]}, {result[1]}) has the largest product ({target}).");
            }
        }


    }
}
