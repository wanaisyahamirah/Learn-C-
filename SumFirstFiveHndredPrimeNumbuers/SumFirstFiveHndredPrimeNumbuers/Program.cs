using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFirstFiveHndredPrimeNumbuers
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

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static int[] GetFirst500Primes()
        {
            int[] primes = new int[500];
            int count = 0;
            int number = 2;
            while (count < 500)
            {
                if (IsPrime(number))
                {
                    primes[count] = number;
                    count++;
                }
                number++;
            }
            return primes;
        }

        static long SumOfFirst500Primes()
        {
            int[] primes = GetFirst500Primes();
            long sum = 0;
            foreach (int prime in primes)
            {
                sum += prime;
            }
            return sum;
        }

        static void PrintResult(long sum)
        {
            Console.WriteLine($"The sum of the first 500 primes is {sum}.");
        }
    }
}
