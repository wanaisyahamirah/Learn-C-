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

            int num = GetUserInput();
            Boolean isPali = IsPalindrome(num);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static int GetUserInput()
        {
            Console.Write("Enter any number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static String ConvertNumToString(int inputNumber)
        {
            return inputNumber.ToString();
        }

        static Boolean IsPalindrome(int inputNumber)
        {
            String inputString =ConvertNumToString(inputNumber);

            // Set up two pointers, one at the beginning and one at the end of the string
            int start = 0;
            int end = inputString.Length - 1;

            // Compare the characters at each pointer position and move the pointers inward until they meet in the middle
            while (start < end)
            {
                if (inputString[start] != inputString[end])
                {
                    // The characters don't match, so the number is not a palindrome
                    return false;
                }
                start++;
                end--;
            }

            // If the pointers have met in the middle, the number is a palindrome
            return true;
        }
        
        static void PrintMessage(String inputString, Boolean isPalindrome)
        {
            if (isPalindrome)
            {
                Console.WriteLine(inputString + " is Palindrome Number");
            }
            else
            {
                Console.WriteLine(inputString + " is not Palindrome Number");
            }
        }
    }
}
