using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
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

        static double GetTemperatureInCelcius()
        {
            // Get Celsius temperature from user
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            return celsius;
        }

        static double ConvertToKelvin(double celsius)
        {
            // Convert Celsius to Kelvin using the formula K = C + 273.15
            double kelvin = celsius + 273.15;
            return kelvin;
        }

        static double ConvertToFahrenheit(double celsius)
        {
            // Convert Celsius to Fahrenheit using the formula F = (C * 1.8) + 32
            double fahrenheit = (celsius * 1.8) + 32;
            return fahrenheit;
        }

        static void PrintResult(double kelvin, double farenheit)
        {

        }


    }
}
