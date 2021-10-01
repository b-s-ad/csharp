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
            WriteLine("\n\tUC 7\n" + "\n Rule2 – Should have at least 1 numeric number in the password");
            WriteLine("-NOTE – All rules must be passed");
            WriteLine("\nDefault Value : abcdabAd1 \n");
            WriteLine(patterns.validateRule3("abcdabAd1"));
            WriteLine("\nEnter New Valid Input : \n");
            WriteLine(patterns.validateRule3(ReadLine()));
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