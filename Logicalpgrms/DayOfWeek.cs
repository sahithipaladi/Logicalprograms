using System;
using System.Collections.Generic;
using System.Text;

namespace Logicalpgrms
{
    class DayOfWeek
    {
        public static void Readinput()
        {
            // Input for Day, Month, Year is given
            Console.Write("Enter the Day : ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Month : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            dayofweek(day, month, year);
        }

        public static void dayofweek(int day, int month, int year)
        {
            // The Gregorian calendar formula is applyed
            int year1 = year - (14 - month) / 12;
            int x = year1 + (year1 / 4) - (year1 / 100) + (year1 / 400);
            int month1 = month + 12 * ((14 - month) / 12) - 2;
            int day1 = (day + x + 31 * month1 / 12) % 7;

            PrintDay(day1);
        }
        public static void PrintDay(int day)
        {
            switch (day)
            {
                case 0:
                    Console.Write("Sunday");
                    break;
                case 1:
                    Console.Write("Monday");
                    break;
                case 2:
                    Console.Write("Tuesday");
                    break;
                case 3:
                    Console.Write("Wednesday");
                    break;
                case 4:
                    Console.Write("Thursday");
                    break;
                case 5:
                    Console.Write("Friday");
                    break;
                case 6:
                    Console.Write("Saturday");
                    break;
                default:
                    break;
            }
        }
    }
}
