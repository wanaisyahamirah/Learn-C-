using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            int num = 5;
            Boolean isPrimeNum = IsPrimeNumber(num);
            PrintMessage(num, isPrimeNum);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static Boolean IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void GetPrimeNumber(int num)
        {
            Boolean isPrimeNum;

            if (num <= 1)
            {
                isPrimeNum = false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrimeNum = false;
                }
            }

            isPrimeNum = true;

            PrintMessage(num, isPrimeNum);
        }

        static void PrintMessage(int num, Boolean isPrimeNum)
        {
            if (isPrimeNum)
            {
                Console.WriteLine(num + " is Prime Number");
            }
            else
            {
                Console.WriteLine(num + " is not Prime Number");
            }
        }

        static int GetUserInput()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
