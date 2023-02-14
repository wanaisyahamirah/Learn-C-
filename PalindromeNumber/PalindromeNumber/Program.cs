using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {

        /*
            -- Wikipedia
            A palindromic number (also known as a numeral palindrome or a numeric palindrome) 
            is a number (such as 16461) that remains the same when its digits are reversed.
        */
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static int GetUserInput()
        {
            Console.Write("Enter any number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        
    }
}
