using System;
using System.Collections.Generic;
using System.Text;

namespace Logicalpgrms
{
    class Binary
    {
        public static void Readinput()
        {
            ToBinary.Readinput();
            int number = ToBinary.number;
            int[] binaryNum = ToBinary.binaryNum;
            int[] swap_binaryNum = new int[32];
            int count = 8, i, j = 0;
            Console.WriteLine("\n");
            // printing binary array in reverse order
            for (i = count / 2 - 1; i >= 0; i--)
            {
                swap_binaryNum[j] = binaryNum[i];
                j++;
            }

            for (i = count - 1; i > count / 2 - 1; i--)
            {
                swap_binaryNum[j] = binaryNum[i];
                j++;
            }
            Console.Write("Binary Number after Swap nibbles : ");
            for (i = 0; i < count; i++)
                Console.Write(swap_binaryNum[i]);

            int decVal = 0, baseVal = 1, n;

            for (i = count - 1; i >= 0; i--)
            {
                n = swap_binaryNum[i];
                decVal = decVal + n * baseVal;
                baseVal = baseVal * 2;
            }

            Console.Write("\nDecimal Number after Swap nibbles : " + decVal + "\n");

            Boolean result = (int)(Math.Ceiling((Math.Log(decVal) / Math.Log(2)))) == (int)(Math.Floor(((Math.Log(decVal) / Math.Log(2)))));

            if (result)
                Console.WriteLine("The number " + decVal + " is a power of 2 : Yes \n");
            else
                Console.WriteLine("The number " + decVal + " is a power of 2 : No \n");
        }
    }
}





