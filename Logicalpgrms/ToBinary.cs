using System;
using System.Collections.Generic;
using System.Text;

namespace Logicalpgrms
{
    class ToBinary
    {
        public static int number;
        // Binary array is created
        public static int[] binaryNum = new int[32];
        public static void Readinput()
        {
            Console.Write("Enter the Decimal Number : ");
            number = Convert.ToInt32(Console.ReadLine());

            Decimal_To_Binary_Conversion();
        }

        public static void Decimal_To_Binary_Conversion()
        {

            int i = 0;
            int count = 8;
            int number1 = number;
            while (number1 > 0)
            {
                // remainder is pushed into binary array
                binaryNum[i] = number1 % 2;
                number1 = number1 / 2;
                i++;
            }
            for (int j = i; i < count; i++)
                binaryNum[i] = 0;
            Console.Write("Binary Number for " + number + " is : ");
            // printing binary array in reverse order
            for (int j = i - 1; j >= 0; j--)
                Console.Write(binaryNum[j]);

        }
    }
}
