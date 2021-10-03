using static System.Console;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegexPatternMatching
{
    class ProgramIE9
    {
        public static void IE9()
        {
            Mainmenu();
        }
        static void Mainmenu()
        {
            Clear();
            Patterns9 patterns = new Patterns9();
            WriteLine("\n\tUC 9\n" + "\nSample Emails to Test\n");
            WriteLine("B. InValid Emails 09");
            WriteLine("\nDefault Value : abc..2002@gmail.com \t– double dots “.” are not allow");
            WriteLine(patterns.validateIVE9("abc..2002@gmail.com"));
            WriteLine("\nValid Value : abc.2002@gmail.com");
            WriteLine(patterns.validateIVE9("abc.2002@gmail.com"));
            WriteLine("\nEnter New Valid |or| InValid Input : \n");
            WriteLine(patterns.validateIVE9(ReadLine()));
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