using static System.Console;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegexPatternMatching
{
    class ProgramIE8
    {
        public static void IE8()
        {
            Mainmenu();
        }


        static void Mainmenu()
    {
        Clear();
        Patterns8 patterns = new Patterns8();
        WriteLine("\n\tUC 9\n" + "\nSample Emails to Test\n");
        WriteLine("B. InValid Emails 08");
        WriteLine("\nDefault Value : abc@%*.com \t– email’s tld is only allow character and digit");
        WriteLine(patterns.validateIVE8("abc@%*.com"));
        WriteLine("\nValid Value : abcA1b2C@mail123ABC.com");
        WriteLine(patterns.validateIVE8("abcA1b2C@mail123ABC.com"));
        WriteLine("\nEnter New Valid |or| InValid Input : \n");
        WriteLine(patterns.validateIVE8(ReadLine()));
        WriteLine("\nPress Enter To Type Value  || 0 = Return to Main Menu || 00 = To Exit");


        string Menu;
        Menu = ReadLine();
        switch (Menu)
        {
            case "0":

                RegexPatternMatching.Class1.Menu();
                System.Environment.Exit(1);
                break;

            case "00":

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
