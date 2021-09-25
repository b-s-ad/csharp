using System;
using static System.Console;

namespace FindMaxNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tFind max Number\n");
            WriteLine("Given Max Number at 1st Position return the Same Number : 33, 11, 22 ");
            WriteLine("Given Max Number at 2nd Position return the Same Number : 22, 33, 11 ");
            WriteLine("Given Max Number at 3rd Position return the Same Number : 22, 11, 33");
            WriteLine("");
            int output = MaximumNumberCheck.MaximumIntegerNumber(33, 11, 22);
            Console.WriteLine(output);
            int output2 = MaximumNumberCheck.MaximumIntegerNumber(22, 33, 11);
            Console.WriteLine(output2);
            int output3 = MaximumNumberCheck.MaximumIntegerNumber3(22, 11, 33);
            Console.WriteLine(output3);
            ReadLine();
           
        }

    }
}
