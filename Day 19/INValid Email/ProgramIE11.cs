using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace RegexPatternMatching
{
    class ProgramIE11   
    {
        public static void IE11()
    {
        Mainmenu();
    }
    static void Mainmenu()
    {
        Clear();
        Patterns11 patterns = new Patterns11();
        WriteLine("\n\tUC 9\n" + "\nSample Emails to Test\n");
        WriteLine("B. InValid Emails 11");
        WriteLine("\nDefault Value : abc@abc@gmail.com \t– double “@” is not allow");
        WriteLine(patterns.validateIVE11("abc@abc@gmail.com"));
        WriteLine("\nValid Value : abcABC@gmail.com");
        WriteLine(patterns.validateIVE11("abcABC@gmail.com"));
        WriteLine("\nEnter New Valid |or| InValid Input : \n");
        WriteLine(patterns.validateIVE11(ReadLine()));
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