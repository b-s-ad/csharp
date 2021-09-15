using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_Ladder
{
    class UC2Rollsdie
    {
        public static void Rollsdice()
        {
            Random rnd = new Random();
            int rollsdice = rnd.Next(1, 7);
            Console.WriteLine(rollsdice);
            Console.ReadLine();
        
        }
    }
}
