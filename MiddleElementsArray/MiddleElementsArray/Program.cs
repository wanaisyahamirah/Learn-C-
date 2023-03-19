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
            // Get input from user
            int[] arr1 = GetInput();
            int[] arr2 = GetInput();
            int[] arr3 = GetInput();

            // Create new array of middle elements
            int[] newArray = new int[] { arr1[1], arr2[1], arr3[1] };

            PrintResult(newArray);

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

        static void PrintResult(int[] newArray)
        {
            // Print result
            Console.WriteLine("New array: [{0}]", string.Join(", ", newArray));
        }
    }
}
