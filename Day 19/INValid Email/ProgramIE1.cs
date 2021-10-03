using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Text.RegularExpressions;

namespace RegexPatternMatching
{
    class ProgramIE1
    {
        public static void IE1()
        {
            Mainmenu();
        }


        static void Mainmenu()
    {
    Clear();
    Patterns1 patterns = new Patterns1();
    WriteLine("\n\tUC 9\n" + "\nSample Emails to Test\n");
    WriteLine("B. InValid Emails 01");
    WriteLine("\nDefault Value : abc – must contains “@” symbol");
    WriteLine(patterns.validateIVE1("abc"));
    WriteLine("\nValid Value : abc@");
    WriteLine(patterns.validateIVE1("abc@"));
    WriteLine("\nEnter New Valid |or| InValid Input : \n");
    WriteLine(patterns.validateIVE1(ReadLine()));
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