using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyXYZ
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            
            int x, y, z;
            GetNumbers(out x, out y, out z);

            int result1 = MultiplyAndAdd(x, y, z);
            int result2 = AddAndMultiply(x, y, z);

            PrintResults(result1, result2);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static void GetNumbers(out int x, out int y, out int z)
        {
            Console.Write("Enter the first number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            z = Convert.ToInt32(Console.ReadLine());
        }

        static int MultiplyAndAdd(int x, int y, int z)
        {
            int result = (x + y) * z;
            return result;
        }

        static int AddAndMultiply(int x, int y, int z)
        {
            int result = (x * y) + (y * z);
            return result;
        }

        static void PrintResults(int result1, int result2)
        {
            Console.WriteLine("Result of (x + y) * z: " + result1);
            Console.WriteLine("Result of x * y + y * z: " + result2);
        }
    }
}
