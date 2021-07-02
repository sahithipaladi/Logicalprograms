using System;
using System.Collections.Generic;
using System.Text;

namespace Logicalpgrms
{
    class SquareRoot
    {
        public static void Readinput()
        {
            Console.Write("Enter the Number : ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Power : ");
            double power = Convert.ToDouble(Console.ReadLine());
            squareRoot(number, power);
        }
        public static void squareRoot(double n, double l)
        {
            double x = n;

            // The closed guess will be stored in the root
            double root;

            while (true)
            {

                root = 0.5 * (x + (n / x));

                if (Math.Abs(root - x) < l)
                    break;

                x = root;
            }

            Console.WriteLine("Square Root of " + n + " is : " + root);
        }
    }
}
