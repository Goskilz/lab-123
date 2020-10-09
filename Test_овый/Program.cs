using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Test_овый
{
    class Program
    {
        static void Main()
        {
            int x;
            Console.WriteLine("Enter value");
            string input = Console.ReadLine();
            Console.WriteLine(Int32.TryParse(input, out x));
            Console.WriteLine(x);


        }
    }
}
