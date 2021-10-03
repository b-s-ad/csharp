using static System.Console;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegexPatternMatching
{
    class ProgramIE6
    {
        public static void IE6()
        {
            Mainmenu();
        }

        static void Mainmenu()
        {
            Clear();
            Patterns6 patterns = new Patterns6();
            WriteLine("\n\tUC 9\n" + "\nSample Emails to Test\n");
            WriteLine("B. InValid Emails 06");
            WriteLine("\nDefault Value : .abc@abc.com \t– email’s 1st character can not start with “.”");
            WriteLine(patterns.validateIVE6(".abc@abc.com"));
            WriteLine("\nValid Value : abc@abc.com");
            WriteLine(patterns.validateIVE6("abc@abc.com"));
            WriteLine("\nEnter New Valid |or| InValid Input : \n");
            WriteLine(patterns.validateIVE6(ReadLine()));
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