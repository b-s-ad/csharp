using System;
using static System.Console;

namespace RegexPatternMatching
{
    class ProgramIE12
    {
        public static void IE12()
        {
            Mainmenu();
        }

        static void Mainmenu()
        {
            Clear();
            PatternsIE12 patterns = new PatternsIE12();
            WriteLine("\n\tUC 9\n" + "\nSample Emails to Test\n");
            WriteLine("B. InValid Emails 12");
            WriteLine("\nDefault Value : abc@gmail.com.1a \t-email’s tld which has two characters can not contains digit");
            WriteLine(patterns.validateIVE12("abc@gmail.com.1a"));
            WriteLine("\nValid Value : abc@gmail.com.au");
            WriteLine(patterns.validateIVE12("abc@gmail.com.au"));
            WriteLine("\nEnter New Valid |or| InValid Input : \n");
            WriteLine(patterns.validateIVE12(ReadLine()));
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