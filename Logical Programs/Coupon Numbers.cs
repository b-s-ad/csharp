using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Int32;


namespace Logical_Programs
{
    class Coupon_Numbers
    {
        public static void cnum(int distinct = 0, int coupon = 0, int newone = 0, int count = 0)
        {
            
            WriteLine("Coupon Numbers\n\n\nEnter Distinct Coupon Number : ");
            coupon = Convert.ToInt32(ReadLine());
            bool[] isCollected = new bool[coupon];
            while (distinct < coupon)
            {
                Random random = new Random();
                newone = (int)(random.NextDouble() * coupon);
                count++;
                if (!isCollected[newone])
                {
                    distinct++;
                    isCollected[newone] = true;
                }
            }

            WriteLine("Total random number needed to have all distinct numbers : " + count);
        }
    }

}