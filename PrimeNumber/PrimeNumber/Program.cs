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
            int num = GetUserInput();

            Console.WriteLine("Method 1 --You entered: " + num);
            Boolean isPrimeNum = IsPrimeNumber(num);
            PrintMessage(num, isPrimeNum);

            Console.WriteLine("Method 2 --You entered: " + num);
            GetPrimeNumber(num);

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
            Boolean isPrimeNum = true;

            if (num <= 1)
            {
                isPrimeNum = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrimeNum = false;
                        break;
                    }
                }
            }

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

    /*
        Explanation:

        IsPrimeNumber is a method that takes an integer argument num and returns a Boolean value indicating whether the num is prime or not. 
        This method determines whether the given num is prime or not by checking if num is less than or equal to 1, in which case it returns false. 
        If num is greater than 1, it checks whether num is divisible by any number from 2 to the square root of num. 
        If it is divisible, then the method returns false, indicating that num is not prime. 
        If num is not divisible by any of these numbers, the method returns true, indicating that num is prime.

        GetPrimeNumber is a method that takes an integer argument num and prints a message indicating whether the num is prime or not. 
        This method uses the IsPrimeNumber method to determine if num is prime, and if it is, it prints a message indicating that num is prime. 
        If num is not prime, it also prints a message indicating that num is not prime.

        The main difference between these two methods is that IsPrimeNumber returns a Boolean value indicating whether num is prime or not, 
        while GetPrimeNumber prints a message indicating whether num is prime or not.
     
     */
}
