using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class Fibonacci_Series
    {
        public static void Fibonacci()

        {
            double n1 = 0, n2 = 1, n3, i, number;
            Console.WriteLine("\nFibonacci series\n");
            Console.Write("\nEnter the number of elements : ");
            number = double.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            
            for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }

}