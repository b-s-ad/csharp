using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace RegexPatternMatching
{
    class ProgramIE10
    {
        public static void IE10()
        {
            Mainmenu();
        }
        static void Mainmenu()
        {
            Clear();
            Patterns10 patterns = new Patterns10();
            WriteLine("\n\tUC 9\n" + "\nSample Emails to Test\n");
            WriteLine("B. InValid Emails 10");
            WriteLine("\nDefault Value : abc.@gmail.com \t– email’s last character can not end with dot “.”");
            WriteLine(patterns.validateIVE10("abc.@gmail.com"));
            WriteLine("\nValid Value : abc@gmail.com");
            WriteLine(patterns.validateIVE10("abc@gmail.com"));
            WriteLine("\nEnter New Valid |or| InValid Input : \n");
            WriteLine(patterns.validateIVE10(ReadLine()));
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