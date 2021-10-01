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
            WriteLine("\n\tUC 4\n" + "\n As a User need to follow pre-defined Mobile Format" + "\n-E.g. 91 9919819801");
            WriteLine("-Country code follow by space and 10 digit number");
            WriteLine("\nDefault Value : 91 9919819801\n");
            WriteLine(patterns.validateMobileFormat("91 9919819801"));
            WriteLine("\nEnter New Valid Input : \n");
            WriteLine(patterns.validateMobileFormat (ReadLine()));
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