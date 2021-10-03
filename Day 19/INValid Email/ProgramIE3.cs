using System;
using System.Collections.Generic;
using static System.Console;
using System.Text.RegularExpressions;
using System.Text;

namespace RegexPatternMatching
{
    class ProgramIE3
    {
        public static void IE3()
        {
            Mainmenu();
        }

        static void Mainmenu()
        {
            Clear();
            Patterns3 patterns = new Patterns3();
            WriteLine("\n\tUC 9\n" + "\nSample Emails to Test\n");
            WriteLine("B. InValid Emails 03");
            WriteLine("\nDefault Value : abc123@gmail.a  \t–“.a” is not a valid tld, last tld must contains at least two characters");
            WriteLine(patterns.validateIVE3("abc123@gmail.a"));
            WriteLine("\nValid Value : abc123@gmail.ac");
            WriteLine(patterns.validateIVE3("abc123@gmail.ac"));
            WriteLine("\nEnter New Valid |or| InValid Input : \n");
            WriteLine(patterns.validateIVE3(ReadLine()));
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