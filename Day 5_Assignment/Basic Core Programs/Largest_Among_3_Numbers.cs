using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Basic_Core_Programs
{
    class Largest_Among_3_Numbers
    {
        public static void Largest3Num()
        {
            Console.WriteLine("\nProgram to Find the Largest Among Three Numbers\n");
            Console.WriteLine("Enter Three Number : \n");
            var num1 = Convert.ToDouble(Console.ReadLine());
            var num2 = Convert.ToDouble(Console.ReadLine());
            var num3 = Convert.ToDouble(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("\nNumber one is the largest!\n");
                }
                else
                {
                    Console.Write("\nNumber three is the largest!\n");
                }
            }
            else if (num2 > num3)
    Console.Write("\nNumber two is the largest!\n");
else
    Console.Write("\nNumber three is the largest!\n");
        }
    }
}
