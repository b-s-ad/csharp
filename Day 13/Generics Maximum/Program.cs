using System;
using static System.Console;

namespace FindMaxNum
{
    class Program  // UC 4 : Extend the max method take more then three parameters 
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("\tFind max Number\n");
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



            WriteLine("\nGiven Max Number at 1st Position return the Same Strings Number : |''33''|,|''22''|,|''11''|");
            WriteLine("Given Max Number at 2nd Position return the Same Strings Number : |''11''|,|''33''|,|''22''|");
            WriteLine("Given Max Number at 3rd Position return the Same Strings Number : |''22''|,|''11''|,|''33''|");
            WriteLine("");
            string strigoutput = MaximumNumberCheck.MaximumStringNumber("33", "22", "11");
            Console.WriteLine(strigoutput);
            string strigoutput2 = MaximumNumberCheck.MaximumStringNumber2("11", "33", "22");
            Console.WriteLine(strigoutput2);
            string strigoutput3 = MaximumNumberCheck.MaximumStringNumber3("22", "11", "33"+"\n========================================================================");
            Console.WriteLine(strigoutput3);


            WriteLine("\t3 Strings E.g. Apple Peach Banana");
            WriteLine("\nGiven Max Number at 1st Position return the Same Strings Number : |''Peach''|,|''Apple''|,|''Banana''|");
            WriteLine("Given Max Number at 2nd Position return the Same Strings Number : |''Banana''|,|''Peach''|,|''Apple''|");
            WriteLine("Given Max Number at 3rd Position return the Same Strings Number : |''Banana''|,|''Apple''|,|''Peach''|");
            WriteLine("");
            string strigoutputS = MaximumNumberCheck.MaximumStringNumber("Peach", "Apple", "Banana");
            Console.WriteLine(strigoutputS);
            string strigoutputS2 = MaximumNumberCheck.MaximumStringNumber2("Banana", "Peach", "Apple");
            Console.WriteLine(strigoutputS2);
            string strigoutputS3 = MaximumNumberCheck.MaximumStringNumber3("Banana", "Apple", "Peach");
            Console.WriteLine(strigoutputS3);
*/

            Console.WriteLine("\tFind max Number\n");
            
            WriteLine("Given Max Number Integer : 33, 11, 22 ");
            WriteLine("\nGiven Max Number Floats : 111.2, 22.45, 78.56");
            WriteLine("\nGiven Max Number Strings Number : |''22''|,|''33''|,|''44''|");
            WriteLine("\nGiven Max Number Strings Words : |''Apple''|,|''Peach''|,|''Banana''|\n");
            ReadKey();

            int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
            double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(111.2, 22.45, 78.56);
            Console.WriteLine(doubleoutput);
            string strigoutput = MaximumNumberCheck.MaximumStringNumber("22", "33", "44");
            Console.WriteLine(strigoutput);
            string strigoutputS3 = MaximumNumberCheck.MaximumStringNumber3("Apple", "Peach", "Banana");
            Console.WriteLine(strigoutputS3);
            ReadLine();


            WriteLine("\tUC 4 : take more then three parameters \n\nGiven Max Number Integer to take more then three parameters : 112, 344, 432, 555, 678 ");
            WriteLine("\nGiven Max Number Floats to take more then three parameters : : 11.2, 34.4, 4.32, 55.5, 6.78 ");
            WriteLine("\nGiven Max Number Strings Number to take more then three parameters : |''111''|,|''222''|,|''333''|''55''|''999''|\n");
            
            ReadKey();
            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "111", "222", "333", "55", "999"};
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            //GenericMaximum<Employee> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
            Console.ReadKey();
           
               
        

           







        }

    }
}
