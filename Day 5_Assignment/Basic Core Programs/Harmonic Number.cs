using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class Harmonic_Number
    {
        public static void Harmonic()
        {
            int i, n;
            double s = 0.0;

            Console.Write("\n\n");
            Console.Write("Program to Print the Nth Harmonic Value\n");
            Console.Write("\n\n");   
   
             Console.Write("Enter the Nth Number : ");
             n= Convert.ToInt32(Console.ReadLine());    
            Console.Write("\n\n");
            for(i=1;i<=n;i++)
            {
            Console.Write("1/{0} + ",i);
            s+=1/(float) i;
            }
            Console.Write("\nSum of Series upto {0} terms : {1} \n",n,s);
            } 
         }
}
