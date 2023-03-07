using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexLowercaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            String inputString = GetStringInput();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static String GetStringInput()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            return str;
        }

        static int[] GetLowerCaseIndices(string str)
        {
            int[] indices = new int[str.Length];
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i]))
                {
                    indices[count] = i;
                    count++;
                }
            }

            int[] trimmedIndices = new int[count];
            Array.Copy(indices, trimmedIndices, count);

            return trimmedIndices;
        }
    }
}
