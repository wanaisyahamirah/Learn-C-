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
            Console.WriteLine("Hello World!");
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
    }
}
