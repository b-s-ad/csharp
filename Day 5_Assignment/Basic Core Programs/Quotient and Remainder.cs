using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class Quotient_and_Remainder
    {
        public static void QuoRem()
        {
            int num, div, rem, quo = 0;
            Console.WriteLine("Program to Compute Quotient and Remainder\n");
            Console.Write("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a divisor : ");
            div = Convert.ToInt32(Console.ReadLine());
            if (num > div)
            {
                while (num >= div)
                {
                    num = num - div;
                    quo++;
                }

                rem = num;
                Console.WriteLine("\nThe quotient is : " + quo + "\nThe remainder is : " + rem);
            }
            else
                Console.WriteLine("Please enter valid values.");

            Console.ReadLine();
        }
    }
}
