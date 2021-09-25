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
            
            
            WriteLine("\nGiven Max Number at 1st Position return the Same Floats Number : 111.2, 22.45, 78.56");
            WriteLine("Given Max Number at 2nd Position return the Same Floats Number : 22.45, 111.2, 78.56");
            WriteLine("Given Max Number at 3rd Position return the Same Floats Number : 78.56, 22.45, 111.2");
            WriteLine("");
            double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(111.2, 22.45, 78.56);
            Console.WriteLine(doubleoutput);
            double doubleoutput2 = MaximumNumberCheck.MaximumFloatNumber2(22.45, 111.2, 78.56);
            Console.WriteLine(doubleoutput2);
            double doubleoutput3 = MaximumNumberCheck.MaximumFloatNumber3(78.56, 22.45, 111.2);
            Console.WriteLine(doubleoutput3);

            
            
            
            WriteLine($"\nGiven Max Number at 1st Position return the Same Strings Number : |''33''|,|''22''|,|''11''|");
            WriteLine("Given Max Number at 2nd Position return the Same Strings Number : |''11''|,|''33''|,|''22''|");
            WriteLine("Given Max Number at 3rd Position return the Same Strings Number : |''22''|,|''11''|,|''33''|");
            WriteLine("");
            string strigoutput = MaximumNumberCheck.MaximumStringNumber("33", "22", "11");
            Console.WriteLine(strigoutput);
            string strigoutput2 = MaximumNumberCheck.MaximumStringNumber3("11", "33", "22");
            Console.WriteLine(strigoutput2);
            string strigoutput3 = MaximumNumberCheck.MaximumStringNumber3("22", "11", "33");
            Console.WriteLine(strigoutput3);
            ReadLine();

        }

    }
}
