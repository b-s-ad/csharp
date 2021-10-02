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
            WriteLine("B. InValid Emails 11");
            WriteLine("\nDefault Value : abc@abc@gmail.com \t– double “@” is not allow");
            WriteLine(patterns.validateIVE11("abc@abc@gmail.com"));
            WriteLine("\nValid Value : abcABC@gmail.com");
            WriteLine(patterns.validateIVE11("abcABC@gmail.com"));
            WriteLine("\nEnter New Valid |or| InValid Input : \n");
            WriteLine(patterns.validateIVE11(ReadLine()));
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