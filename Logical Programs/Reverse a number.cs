using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class Reverse_a_number
    {
        public static void Reverse()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Reverse a number\n");
            Console.WriteLine("Enter a number : ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("\nReversed Number is : " + reverse);
        }
    }
    }

