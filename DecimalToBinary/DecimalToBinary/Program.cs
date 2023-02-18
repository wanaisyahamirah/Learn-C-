using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            int decimalNum = GetUserInput();
            String binaryNum = ConvertDecimalToBinary(decimalNum);
            PrintMessage(decimalNum, binaryNum);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static int GetUserInput()
        {
            Console.Write("Enter any number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static String ConvertDecimalToBinary(int decimalNum)
        {
            int quotient, remainder;
            quotient = 0;
            remainder = 0;
            String binaryNum = "";

            quotient = decimalNum;

            while (quotient >= 2)
            {
                remainder = quotient % 2;
                binaryNum = remainder.ToString() + binaryNum;
                quotient = quotient / 2;
            }

            binaryNum = remainder.ToString() + binaryNum;

            return binaryNum;
        }

        static void PrintMessage(int decNum, String binNum)
        {
            Console.WriteLine($"The binary equivalent of {decNum} is {binNum}.");
        }
    }
}
