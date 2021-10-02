using System;
using static System.Console;

namespace RegexPatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Mainmenu();
        }

        static void Mainmenu()
        {
            Clear();
            Patterns patterns = new Patterns();
            WriteLine("\n\tUC 9\n" + "\nSample Emails to Test\n");
            WriteLine("A. Valid Emails 08");
            WriteLine("\nDefault Value : abc@gmail.com.com \n");
            WriteLine(patterns.validateVE8("abc@gmail.com.com"));
            WriteLine("\nEnter New Valid Input : \n");
            WriteLine(patterns.validateVE8(ReadLine()));
            WriteLine("\nPress Enter To Type Value  || 0 = To Exit");
            

            string Menu;
            Menu = ReadLine();
            switch (Menu)
            {
                case "0":
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