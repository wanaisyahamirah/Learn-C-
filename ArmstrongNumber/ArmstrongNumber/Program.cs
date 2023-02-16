using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            int num = GetUserInput();
            Boolean isArmStrong = IsArmstrongNumber(num);
            PrintMessage(num, isArmStrong);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static int GetUserInput()
        {
            Console.Write("Enter any number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static Boolean IsArmstrongNumber(int num)
        {
            int count, temp, sum, digit;
            count = 0;
            temp = num;

            while(temp > 0)
            {
                count = count + 1;
                temp = temp / 10;
            }

            sum = 0;
            temp = num;

            while (temp > 0)
            {
                digit = temp % 10;
                sum = sum + (int)Math.Pow(digit, count);
                temp = temp / 10;
            }

            if (sum == num)
            {
                return true;
            }
            return false;            

        }

        static void PrintMessage(int inputNumber, Boolean result)
        {
            Console.WriteLine("result is " + result);
            if(result)
            {
                Console.WriteLine(inputNumber + " is an Armstrong Number");
            }
            else
            {
                Console.WriteLine(inputNumber + " is not an Armstrong Number");
            }
        }
    }
}
