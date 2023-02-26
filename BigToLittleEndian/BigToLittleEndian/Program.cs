using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigToLittleEndian
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

        // Method to convert a Big Endian byte array to Little Endian
        static byte[] ConvertBigEndianToLittleEndian(byte[] bigEndianBytes)
        {
            // Create a new byte array to hold the Little Endian bytes
            byte[] littleEndianBytes = new byte[bigEndianBytes.Length];

            // Reverse the order of the bytes
            for (int i = 0; i < bigEndianBytes.Length; i++)
            {
                littleEndianBytes[i] = bigEndianBytes[bigEndianBytes.Length - 1 - i];
            }

            return littleEndianBytes;
        }
    }
}
