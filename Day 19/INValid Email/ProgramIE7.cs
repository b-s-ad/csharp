using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class ProgramIE7
    {
        public static void IE7()
        {
            Mainmenu();
        }
        static void Mainmenu()
        {
            Clear();
            Patterns7 patterns = new Patterns7();
            WriteLine("\n\tUC 9\n" + "\nSample Emails to Test\n");
            WriteLine("B. InValid Emails 07");
            WriteLine("\nDefault Value : abc()*@gmail.com \t– email’s is only allow character, digit, underscore and dash");
            WriteLine(patterns.validateIVE7("abc()*@gmail.com"));
            WriteLine("\nValid Value : a-b_c_1-2-A@gmail.com");
            WriteLine(patterns.validateIVE7("a-b_c_1-2-A@gmail.com"));
            WriteLine("\nEnter New Valid |or| InValid Input : \n");
            WriteLine(patterns.validateIVE7(ReadLine()));
            WriteLine("\nPress Enter To Type Value  || 0 = Return to Main Menu || 00 = To Exit");


            string Menu;
            Menu = ReadLine();
            switch (Menu)
            {
                case "0":

                    RegexPatternMatching.Class1.Menu();
                    System.Environment.Exit(1);
                    break;

                case "00":

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