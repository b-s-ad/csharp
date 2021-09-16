using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class Perfect_Number
    {
        public static void Perfect()
        {
            double n, i, sum;
            Console.Write("Check whether a given number is perfect number or not:\n");

            Console.WriteLine("\nNote: Perfect Number are '6' '28' '496' '8128' '33550336' '8589869056' '137438691328' '2305843008139952128'");
                                   
            Console.Write("\n\n");

            Console.Write("Enter the  number : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            Console.Write("\nThe positive divisor  : ");
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.Write("{0}  ", i);
                }
            }
            Console.Write("\nThe sum of the divisor is : {0}\n", sum );
            if (sum == n)
                Console.Write("\nSo, the number is perfect.");
            else
                Console.Write("\nSo, the number is not perfect.");
            Console.Write("\n");
        }
    }
    }


