using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Core_Programs
{
    class Flip_Coin
    {
        public static void Flip()
        {

            Console.WriteLine("Flip Coin Programs\n");
            Random random = new Random();
           int rnd = random.Next(0, 2);

            if (rnd == 1)
            {
                Console.WriteLine("Its Heads");
            }
            else
            {
                Console.WriteLine("Its Tails");

            }
        }

    }
}