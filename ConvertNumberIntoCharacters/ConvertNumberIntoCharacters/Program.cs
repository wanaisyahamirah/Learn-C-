using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumberIntoCharacters
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

        static string ConvertSingleDigit(int number)
        {
            string words = "";

            switch (number)
            {
                case 1:
                    words = "one";
                    break;
                case 2:
                    words = "two";
                    break;
                // add more cases for other single digits
                // ...
                case 9:
                    words = "nine";
                    break;
            }

            return words;
        }

        static string ConvertTens(int number)
        {
            string words = "";

            switch (number)
            {
                case 2:
                    words = "twenty";
                    break;
                case 3:
                    words = "thirty";
                    break;
                // add more cases for other tens digits
                // ...
                case 9:
                    words = "ninety";
                    break;
            }

            return words;
        }

        static string ConvertHundreds(int number)
        {
            string words = "";

            if (number > 99)
            {
                words += ConvertSingleDigit(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                {
                    words += "and ";
                }

                if (number < 20)
                {
                    words += ConvertSingleDigit(number);
                }
                else
                {
                    words += ConvertTens(number / 10);
                    if (number % 10 > 0)
                    {
                        words += "-" + ConvertSingleDigit(number % 10);
                    }
                }
            }

            return words;
        }

        static string ConvertThousands(int number)
        {
            string words = "";

            if (number > 0)
            {
                words = ConvertHundreds(number) + " thousand ";
            }

            return words;
        }


    }
}