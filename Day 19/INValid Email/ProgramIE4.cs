using static System.Console;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegexPatternMatching
{
    class ProgramIE4
    {
        public static void IE4()
        {
            Mainmenu();
        }

        static void Mainmenu()
        {
            Clear();
            Patterns4 patterns = new Patterns4();
            WriteLine("\n\tUC 9\n" + "\nSample Emails to Test\n");
            WriteLine("B. InValid Emails 04");
            WriteLine("\nDefault Value : abc123@.com  \t– tld can not start with dot “.”");
            WriteLine(patterns.validateIVE4("abc123@.com"));
            WriteLine("\nValid Value : abc123@mail.com");
            WriteLine(patterns.validateIVE4("abc123@mail.com"));
            WriteLine("\nEnter New Valid |or| InValid Input : \n");
            WriteLine(patterns.validateIVE4(ReadLine()));
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
