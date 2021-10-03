using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace RegexPatternMatching
{
    class Class1
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("");
            //Console.ReadLine();  
            Menu();
        }

        public static void Menu()
        {
            Clear();
            WriteLine("\n\tSample Emails to Test\n\nB. Invalid Emails (TLD - Top Level Domains)\n");
            WriteLine("1. abc \t\t\t– must contains “@” symbol");
            WriteLine("2. abc@.com.my \t\t– tld can not start with dot “.”");
            WriteLine("3. abc123@gmail.a \t– “.a” is not a valid tld, last tld must contains at least two characters");
            WriteLine("4. abc123@.com \t\t– tld can not start with dot “.”");
            WriteLine("5. abc123@.com.com \t– tld can not start with dot “.”");
            WriteLine("6. .abc@abc.com \t– email’s 1st character can not start with “.”");
            WriteLine("7. abc()*@gmail.com \t– email’s is only allow character, digit, underscore and dash");
            WriteLine("8. abc@%*.com \t\t– email’s tld is only allow character and digit");
            WriteLine("9. abc..2002@gmail.com \t– double dots “.” are not allow");
            WriteLine("10. abc.@gmail.com \t– email’s last character can not end with dot “.”");
            WriteLine("11. abc@abc@gmail.com \t– double “@” is not allow");
            WriteLine("12. abc@gmail.com.1a \t- email’s tld which has two characters can not contains digit");
            WriteLine("13. abc@gmail.com.aa.au - cannont have multiple email’s tld");
            WriteLine("\n================================================\n\nEnter the Selection [1-13] |Or| 00. To Exit : \n================================================");
            string myoptions;
            WriteLine("\n");
            myoptions = ReadLine();
            switch (myoptions)
            {
                case "00":

                    System.Environment.Exit(1);
                    break;


                case "13":
                    RegexPatternMatching.ProgramIE13.Main13();
                    break;
            
                case "12":
                    RegexPatternMatching.ProgramIE12.IE12();
                break;

                case "11":
                    RegexPatternMatching.ProgramIE11.IE11();
                    break;

                case "10":
                    RegexPatternMatching.ProgramIE10.IE10();
                    break;

                case "9":
                    RegexPatternMatching.ProgramIE9.IE9();
                    break;

                case "8":
                    RegexPatternMatching.ProgramIE8.IE8();
                    break;

                case "7":
                    RegexPatternMatching.ProgramIE7.IE7();
                    break;

                case "6":
                    RegexPatternMatching.ProgramIE6.IE6();
                    break;

                case "5":
                    RegexPatternMatching.ProgramIE5.IE5();
                    break;

                case "4":
                    RegexPatternMatching.ProgramIE4.IE4();
                    break;

                case "3":
                    RegexPatternMatching.ProgramIE3.IE3();
                    break;

                case "2":
                    RegexPatternMatching.ProgramIE2.IE2();
                    break;

                case "1":
                    RegexPatternMatching.ProgramIE1.IE1();
                    break;
            }
            Menu();
        }
        
        }
    }

