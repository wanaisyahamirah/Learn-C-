using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetCenturyFromYear
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            int year = GetYear();
            int century = GetCentury(year);
            string postfix = GetPostfix(century);
            PrintResult(year, century, postfix);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static int GetYear()
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            return year;
        }

        static int GetCentury(int year)
        {
            int century = year / 100;
            if (year % 100 != 0)
            {
                century++;
            }
            return century;
        }

        static string GetPostfix(int century)
        {
            string postfix;
            int lastTwoDigits = century % 100;
            if (lastTwoDigits >= 11 && lastTwoDigits <= 13)
            {
                postfix = "th";
            }
            else
            {
                int lastDigit = lastTwoDigits % 10;
                switch (lastDigit)
                {
                    case 1:
                        postfix = "st";
                        break;
                    case 2:
                        postfix = "nd";
                        break;
                    case 3:
                        postfix = "rd";
                        break;
                    default:
                        postfix = "th";
                        break;
                }
            }
            return postfix;
        }

        static void PrintResult(int year, int century, string postfix)
        {
            Console.WriteLine("{0} belongs to the {1} century.", year, century, postfix);
        }

    }
}
