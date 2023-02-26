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
            
            // Create a sample Big Endian byte array
            byte[] bigEndianBytes = new byte[] { 0x12, 0x34, 0x56, 0x78 };

            // Convert the Big Endian byte array to Little Endian
            byte[] littleEndianBytes = ConvertBigEndianToLittleEndian(bigEndianBytes);

            // Print the original and converted byte arrays
            Console.WriteLine("Original Big Endian Bytes: " + BitConverter.ToString(bigEndianBytes));
            Console.WriteLine("Converted Little Endian Bytes: " + BitConverter.ToString(littleEndianBytes));

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
