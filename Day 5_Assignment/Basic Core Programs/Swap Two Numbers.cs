﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic_Core_Programs
{
    class Swap_Two_Numbers
    {
        public static void Swap()
        {
            int num1, num2, temp;
            Console.WriteLine("Program to Swap Two Numbers \n");
            Console.Write("\nEnter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            Console.Read();
        }
    }
}