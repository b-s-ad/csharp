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
            WriteLine("B. InValid Emails 09");
            WriteLine("\nDefault Value : abc..2002@gmail.com \t– double dots “.” are not allow");
            WriteLine(patterns.validateIVE9("abc..2002@gmail.com"));
            WriteLine("\nValid Value : abc.2002@gmail.com");
            WriteLine(patterns.validateIVE9("abc.2002@gmail.com"));
            WriteLine("\nEnter New Valid |or| InValid Input : \n");
            WriteLine(patterns.validateIVE9(ReadLine()));
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