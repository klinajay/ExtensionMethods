using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
     static class StatsClass
    {
        public static void Test3(this Program p)
        {
            Console.WriteLine("Test 3");
        }
        public static int Factorial(this Int32 intObject , int p)
        {
            int result = 1;
            for(int k = p;  k > 0; k--)
            {
                result = result * k;
            }
            return result;
        }
    }
}
