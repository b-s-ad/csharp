using System;
using static System.Console;

namespace RegexPatternMatching
{
    class ProgramIE13
    {
        public static void Main13()
        {
            Mainmenu();
        }

        static void Mainmenu()
        {
            Clear();
            PatternsIE13 patterns = new PatternsIE13();
            WriteLine("\n\tUC 9\n" + "\nSample Emails to Test\n");
            WriteLine("B. InValid Emails 13");
            WriteLine("\nDefault Value : abc@gmail.com.aa.au \t- cannont have multiple email’s tld");
            WriteLine(patterns.validateIVE13("abc@gmail.com.aa.au"));
            WriteLine("\nValid Value : abc@gmail.com.aa");
            WriteLine(patterns.validateIVE13("abc@gmail.com.aa"));
            WriteLine("\nEnter New Valid |or| InValid Input : \n");
            WriteLine(patterns.validateIVE13(ReadLine()));
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