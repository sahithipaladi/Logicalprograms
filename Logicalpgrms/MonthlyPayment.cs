using System;
using System.Collections.Generic;
using System.Text;

namespace Logicalpgrms
{
    class MonthlyPayment
    {
        public static void Readinput()
        {
            // Input for Day, Month, Year is given
            Console.Write("Enter the Principal loan amount (P) : ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the percent interest compounded (R) : ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Years to pay off (Y) : ");
            double y = Convert.ToDouble(Console.ReadLine());
            Calculate_Monthly_Payment(p, r, y);
        }

        public static void Calculate_Monthly_Payment(double p, double r, double y)
        {
            double n = 12 * y;
            double r1 = r / (12 * 100);
            double payment = (p * r1) / (1 - (Math.Pow((1 + r1), (-n))));
            Console.WriteLine(" PAYMENT : " + payment);
        }
    }
}
