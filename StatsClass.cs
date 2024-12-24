using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public static string ConvertMonth(this Int32 intObject)
        {
            switch(intObject) {
                case 1: return "January";
                case 2: return "February";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
                default:
                    return "Invalid month";
            }
        }
        public static string  ToFriendlyString(this DateTime date)
        {
            var today =  DateTime.Today ;
            int month = date.Month;
            int year = date.Year;
            int day = date.Day;
            if (month == today.Month && year == today.Year && today.Day- day ==  1) {
                return "Yesterday";
            }
            else if(month == today.Month && year == today.Year && today.Day - day == -1)
            {
                return "Tomorrow";
            }
            else if (month == today.Month && year == today.Year && today.Day - day == -2)
            {
                return "Day after tomorrow";
            }
            else if(month == today.Month && year == today.Year && today.Day - day == 2)
            {
                return "Day before yesterday";
            }
            else
            {

                return month.ConvertMonth()+ " " + day.ToString() +", "+ year.ToString() ;
            }

        }
    }
}
