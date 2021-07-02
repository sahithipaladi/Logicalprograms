using System;

namespace Logicalpgrms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the options:");
            Console.WriteLine("1.CouponNumbers");
            Console.WriteLine("2.TemperaturConversion");
            Console.WriteLine("3.DayOfWeek");
            Console.WriteLine("4. MonthlyPayment");
            Console.WriteLine("5.SquareRoot ");
            Console.WriteLine("6. ToBinary");
            Console.WriteLine("7. Binary");
            Console.WriteLine("8. SimulateStopwatch");
            Console.WriteLine("Enter the option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    CouponNumbers.Readinput();
                    break;
                case 2:
                    TemperaturConversion.Readinput();
                    break;
               case 3:
                    DayOfWeek.Readinput();
                    break;
                case 4:
                    MonthlyPayment.Readinput();
                    break;
                case 5:
                    SquareRoot.Readinput();
                    break;
                case 6:
                    ToBinary.Readinput();
                    break;
                case 7:
                    Binary.Readinput();
                    break;
                case 8:
                    SimulateStopwatch.Readinput();
                    break;
                default:
                    Console.WriteLine("Invalid options");
                    break;



            }
        }
    }
}
