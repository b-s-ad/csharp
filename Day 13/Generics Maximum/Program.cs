using System;
using static System.Console;

namespace FindMaxNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tFind max Number\n");
            int output = MaximumNumberCheck.MaximumIntegerNumber(33, 11, 22);
            Console.WriteLine(output);
            double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(22.45, 111.2, 78.56);
            Console.WriteLine(doubleoutput);
            string strigoutput = MaximumNumberCheck.MaximumStringNumber("22", "33", "44");
            Console.WriteLine(strigoutput);
            ReadLine();
        }

    }
}
