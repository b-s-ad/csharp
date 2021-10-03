using static System.Console;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegexPatternMatching
{
    class ProgramIE5
    {
        public static void IE5()
        {
            Mainmenu();
        }

        static void Mainmenu()
        {
            Clear();
            Patterns5 patterns = new Patterns5();
            WriteLine("\n\tUC 9\n" + "\nSample Emails to Test\n");
            WriteLine("B. InValid Emails 05");
            WriteLine("\nDefault Value : abc123@.com.com \t– tld can not start with dot “.”");
            WriteLine(patterns.validateIVE5("abc123@.com.com"));
            WriteLine("\nValid Value : abc123@xyz.com.com");
            WriteLine(patterns.validateIVE5("abc123@xyz.com.com"));
            WriteLine("\nEnter New Valid |or| InValid Input : \n");
            WriteLine(patterns.validateIVE5(ReadLine()));
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

