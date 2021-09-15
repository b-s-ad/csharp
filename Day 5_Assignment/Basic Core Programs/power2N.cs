using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class power2N
    {
        public static void power()
        {
            int val1;
            int val2;
            Console.Write("\n\nFind Power of 2 base N \n");            
            Console.Write("\nEnter Base number: ");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Exponent : ");
            val2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Result : {0} ^ {1} is : {2} ", val1, val2, result(val1, val2));
        }
        public static int result(int val1, int val2)
        {
            int rval = 1;
            int i;
            for (i = 1; i <= val2; i++)
                rval = rval * val1;
            return rval;
        }

    }
}
