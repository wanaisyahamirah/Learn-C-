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

        // The function takes an integer input num and returns a Boolean value.
        static Boolean IsArmstrongNumber(int num)
        {
            // Initializes variables
            int count, temp, sum, digit;

            // count is used to store the number of digits in the input num
            count = 0;

            // temp is a temporary variable used to perform arithmetic operations on the input num
            temp = num;

            // The function then enters a while loop that runs as long as temp is greater than 0. 
            // In each iteration of the loop, the function increments the count variable and divides the temp variable by 10 to remove the last digit. 
            // This way the number of digits in the input num can be calculated.
            while (temp > 0)
            {
                count = count + 1;
                temp = temp / 10;
            }

            // sum is used to store the sum of the digits raised to the power of the count
            sum = 0;
            temp = num;

            while (temp > 0)
            {
                // extracts the last digit of temp and stores it in the digit variable
                digit = temp % 10;

                // Computes the digit raised to the power of count using the Math.Pow function and adds it to the sum variable.
                sum = sum + (int)Math.Pow(digit, count);

                // Removes the last digit from temp by dividing it by 10.
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
