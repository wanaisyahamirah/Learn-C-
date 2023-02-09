using System;
using KaprekarNumber;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaprekarNumber
{
    class Program
    {

        static void Main(string[] args)
        {
            FindKaprekarNumber kaprekarNumber = new FindKaprekarNumber();

            int min = 1;
            int max = 10000;

            for (int i = min; i <= max; i++)
            {
                Boolean isKaprekar = kaprekarNumber.isKaprekarNumber(i);
                if (isKaprekar)
                {
                    Console.WriteLine(i + " YES Kaprekar Number");
                }
                else
                {
                    //Console.WriteLine(number + " NOT Kaprekar Number");
                }
            }
            
            /*
            FindKaprekarNumber kaprekarNumber = new FindKaprekarNumber();

            int min = 1;
            int max = 10000;

            for (int i = min; i <= max; i ++)
            {
                int square = kaprekarNumber.GetSquareNumber(i);
                String squareString = kaprekarNumber.ConvertToString(square);
                int length = kaprekarNumber.GetStringLength(i);
                Boolean isKaprekar = true;
                if (length >= squareString.Length)
                {
                    isKaprekar = false;
                    continue;
                }
                int leftSplit = kaprekarNumber.GetLeftSplitValue(length, squareString);
                int rightSplit = kaprekarNumber.GetRightSplitValue(length, squareString);
                isKaprekar = kaprekarNumber.IsLeftEqualsRight(leftSplit, rightSplit, i);
                kaprekarNumber.DisplayMessage(isKaprekar, i);
            }
            */

            Console.ReadKey();
            
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
                
    }
}
