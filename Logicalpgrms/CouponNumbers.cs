using System;
using System.Collections.Generic;
using System.Text;

namespace Logicalpgrms
{
    class CouponNumbers
    {
        public static void Readinput()
        {
            int couponStart, couponEnd;

            Console.Write("Enter the Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            //Get range for coupon from user
            Console.WriteLine("Enter start range of coupon number");
            couponStart = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter End range of coupon number");
            couponEnd = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int randomNumber = random.Next(couponStart, couponEnd);

            //Create a list..
            List<int> coupon_list = new List<int>();
            // Adding initial random number to list...
            coupon_list.Add(randomNumber);
            int count = 1;
            randomNumber = random.Next(couponStart, couponEnd);
            while (count < number)
            {
                // Checks the Random number genrated is in the list or not
                if (!(coupon_list.Contains(randomNumber)))
                {
                    coupon_list.Add(randomNumber);
                    count++;
                }
                randomNumber = random.Next(couponStart, couponEnd);
            }
            // N Unique Coupons List is printed...
            foreach (int i in coupon_list)
            {
                Console.WriteLine(" Distinct coupon nummber : " + i);
            }
        }
    }
}
