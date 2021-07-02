using System;
using System.Collections.Generic;
using System.Text;

namespace Logicalpgrms
{
    class TemperaturConversion
    {
        public static void Readinput()
        {
            // The temperature Option is given as input 
            Console.WriteLine("Select the options:");
            Console.WriteLine("1.Celsius to Fahrenheit");
            Console.WriteLine("2.Fahrenheit to Celsius");
            Console.Write("Enter the Option : ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CelsiusToFahrenheit();
                    break;
                case 2:
                    FahrenheitToCelsius();
                    break;
                default:
                    Console.WriteLine("Invalid options");
                    break;
            }
        }

        public static void CelsiusToFahrenheit()
        {
            Console.Write("Enter the Celsius Temperature : ");
            int Celsius = Convert.ToInt32(Console.ReadLine());
            double Fahrenheit = (Celsius * 9 / 5) + 32;
            Console.Write("The Fahrenheit Temperature : " + Fahrenheit);
        }
        public static void FahrenheitToCelsius()
        {
            Console.Write("Enter the Fahrenheit Temperature : ");
            int Fahrenheit = Convert.ToInt32(Console.ReadLine());
            double Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.Write("The Celsius Temperature : " + Celsius);
        }
    }
}
