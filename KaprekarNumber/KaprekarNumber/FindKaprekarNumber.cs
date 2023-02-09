using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaprekarNumber
{
    public class FindKaprekarNumber
    {
        public int GetSquareNumber(int number)
        {
            return number * number;
        }

        public String ConvertToString(int squaredNumber)
        {
            return squaredNumber.ToString();
        }

        public int GetStringLength(int number)
        {
            return (number.ToString()).Length;
        }

        public int GetLeftSplitValue(int stringLength, String stringSquaredNumber)
        {
            return int.Parse(stringSquaredNumber.Substring(0, stringLength));
        }

        public int GetRightSplitValue(int stringLength, String stringSquaredNumber)
        {            
            return int.Parse(stringSquaredNumber.Substring(stringLength));
        }

        public Boolean IsLeftEqualsRight(int leftSplit, int rightSplit, int number)
        {
            return (leftSplit + rightSplit == number);
        }

        public void DisplayMessage(Boolean isKaprekar, int number)
        {
            if (isKaprekar)
            {
                Console.WriteLine(number + " YES Kaprekar Number");
            }
            else
            {
                //Console.WriteLine(number + " NOT Kaprekar Number");
            }
            
        }

        public Boolean isKaprekarNumber(int number)
        {
            int square = GetSquareNumber(number);
            String squareString = ConvertToString(square);
            int length = GetStringLength(number);
            Boolean isKaprekar = true;
            if (length >= squareString.Length)
            {
                return false;
            }
            int leftSplit = GetLeftSplitValue(length, squareString);
            int rightSplit = GetRightSplitValue(length, squareString);
            isKaprekar = IsLeftEqualsRight(leftSplit, rightSplit, number);
            return isKaprekar;
        }
    }
    
}
