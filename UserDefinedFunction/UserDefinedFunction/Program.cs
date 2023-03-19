using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetUser();
            Console.WriteLine("Have a nice day!");
            Console.ReadKey();
        }

        static void GreetUser()
        {
            Console.WriteLine("Welcome Friends!");
        }
    }
}
