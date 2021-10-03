using static System.Console;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegexPatternMatching
{
    class ProgramIE2
    {
        public static void IE2()
        {
            Mainmenu();
        }

        static void Mainmenu()
        {
            Clear();
            Patterns2 patterns = new Patterns2();
            WriteLine("\n\tUC 9\n" + "\nSample Emails to Test\n");
            WriteLine("B. InValid Emails 02");
            WriteLine("\nDefault Value : abc@.com.my – tld can not start with dot “.”");
            WriteLine(patterns.validateIVE2("abc@.com.my"));
            WriteLine("\nValid Value : abc@abc.com.my");
            WriteLine(patterns.validateIVE2("abc@abc.com.my"));
            WriteLine("\nEnter New Valid |or| InValid Input : \n");
            WriteLine(patterns.validateIVE2(ReadLine()));
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
