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
            WriteLine("\n\tUC 3\n" + "\n As a User need to enter a valid email"+ "\n-E.g.abc.xyz@bl.co.in");
            WriteLine("-Email has 3 mandatory parts(abc, bl" + "& co) and 2 optional(xyz & in) with " + "precise @ and . positions");
            WriteLine("\nDefault Value : abc.xyz@bl.co.in || abc@bl.co\n");
            WriteLine(patterns.validateValidemail("abc.xyz@bl.co.in"));
            WriteLine("\nEnter New Valid Input : \n");
            WriteLine(patterns.validateValidemail(ReadLine()));
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