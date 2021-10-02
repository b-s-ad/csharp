﻿using System;
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
            WriteLine("B. InValid Emails 04");
            WriteLine("\nDefault Value : abc123@.com  \t– tld can not start with dot “.”");
            WriteLine(patterns.validateIVE4("abc123@.com"));
            WriteLine("\nValid Value : abc123@mail.com");
            WriteLine(patterns.validateIVE4("abc123@mail.com"));
            WriteLine("\nEnter New Valid |or| InValid Input : \n");
            WriteLine(patterns.validateIVE4(ReadLine()));
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