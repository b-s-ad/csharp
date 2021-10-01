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
            WriteLine("\n\tUC 5\n" + "\n As a User need to follow pre-defined Password rules." + "\n-Rule1 – minimum 8 Characters");
            WriteLine("-NOTE – All rules must be passed");
            WriteLine("\nDefault Value : ABCDabcd | abcdABCDEFgh \n");
            WriteLine(patterns.validateMinpass("ABCDabcd"));
            WriteLine("\nEnter New Valid Input : \n");
            WriteLine(patterns.validateMinpass(ReadLine()));
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