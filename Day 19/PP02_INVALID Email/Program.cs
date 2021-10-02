using System;
using static System.Console;

namespace RegexPatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Mainmenu();
        }

        static void Mainmenu()
        {
            Clear();
            Patterns patterns = new Patterns();
            WriteLine("\n\tUC 9\n" + "\nSample Emails to Test\n");
            WriteLine("B. InValid Emails 07");
            WriteLine("\nDefault Value : abc()*@gmail.com \t– email’s is only allow character, digit, underscore and dash");
            WriteLine(patterns.validateIVE7("abc()*@gmail.com"));
            WriteLine("\nValid Value : a-b_c_1-2-A@gmail.com");
            WriteLine(patterns.validateIVE7("a-b_c_1-2-A@gmail.com"));
            WriteLine("\nEnter New Valid |or| InValid Input : \n");
            WriteLine(patterns.validateIVE7(ReadLine()));
            WriteLine("\nPress Enter To Type Value  || 0 = To Exit");
            

            string Menu;
            Menu = ReadLine();
            switch (Menu)
            {
                case "0":
                    System.Environment.Exit(1);
                    break;

                default:
                    WriteLine("");
                    break;
            }
            Mainmenu();
        }
    }

}