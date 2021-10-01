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
            WriteLine("\n\tUC 8\n" + "\n Rule4 – Has exactly 1 Special Character");
            WriteLine("-NOTE – All rules must be passed");
            WriteLine("\nDefault Value : abcda1Ad@ \n");
            WriteLine(patterns.validateRule4("abcda1Ad@"));
            WriteLine("\nEnter New Valid Input : \n");
            WriteLine(patterns.validateRule4(ReadLine()));
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