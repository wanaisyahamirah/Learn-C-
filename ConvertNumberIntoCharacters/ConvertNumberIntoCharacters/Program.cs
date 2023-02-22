using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumberIntoCharacters
{
    class Program
    {
        public static void Main()
        {
            int num = 357546;
            string numInWords = ConvertToWords(num);
            Console.WriteLine(numInWords);
            Console.ReadKey();
        }

        static string ConvertToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + ConvertToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += ConvertToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += ConvertToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += ConvertToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += " ";

                if (number < 20)
                    words += ConvertUnits(number);
                else
                {
                    words += ConvertTens(number / 10);
                    if ((number % 10) > 0)
                        words += "-" + ConvertUnits(number % 10);
                }
            }

            return words;
        }

        static string ConvertUnits(int units)
        {
            string[] unitsMap = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

            return unitsMap[units];
        }

        static string ConvertTens(int tens)
        {
            string[] tensMap = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            return tensMap[tens];
        }

    }
}
