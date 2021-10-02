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
            WriteLine("B. InValid Emails 06");
            WriteLine("\nDefault Value : .abc@abc.com \t– email’s 1st character can not start with “.”");
            WriteLine(patterns.validateIVE6(".abc@abc.com"));
            WriteLine("\nValid Value : abc@abc.com");
            WriteLine(patterns.validateIVE6("abc@abc.com"));
            WriteLine("\nEnter New Valid |or| InValid Input : \n");
            WriteLine(patterns.validateIVE6(ReadLine()));
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