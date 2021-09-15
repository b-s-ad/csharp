using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

 namespace Basic_Core_Programs
    {
        class Even_or_Odd
        {
        public static void Evenodd()
        {
                int i;
                Console.WriteLine("Program to Check Whether a Number is Even or Odd");
                Console.Write("Enter a Number : ");
                i = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    Console.Write("Its is an Even Number");
                    Console.Read();
                }
                else
                {
                    Console.Write("Its is an Odd Number");
                    Console.Read();
                }
            }
        }
    }


