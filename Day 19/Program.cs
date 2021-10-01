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
            WriteLine("\n\tUC 6\n" + "\n Rule2 – Should have at least 1 Upper Case");
            WriteLine("-NOTE – All rules must be passed");
            WriteLine("\nDefault Value : abcdabcdA \n");
            WriteLine(patterns.validateRule2("abcdabcdA"));
            WriteLine("\nEnter New Valid Input : \n");
            WriteLine(patterns.validateRule2(ReadLine()));
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