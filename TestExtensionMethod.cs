using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class TestExtensionMethod
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program p = new Program();
            p.Test1();
            p.Test2();
            p.Test3();
            int number = 5;
            int factorial = number.Factorial(number);
            Console.WriteLine($"Factorial of {number} is {factorial}");
            DateTime dateTime = new DateTime(2017 , 12 , 15);
            string friendlyDate = dateTime.ToFriendlyString();
            Console.WriteLine("On " +friendlyDate + " we met last time");

        }
    }
}
