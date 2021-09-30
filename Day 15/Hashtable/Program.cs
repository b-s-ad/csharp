
using System;
using System.Collections.Generic;
using static System.Console;

namespace HashTable
{
    class Program  //UC 2
    {

        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            Clear();
            WriteLine("\n\t\tHash table UC 2\n");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(18);

            hash.Add("0", "Paranoids"); hash.Add("1", "are"); hash.Add("2", "not");
            hash.Add("3", "paranoid"); hash.Add("4", "because"); hash.Add("5", "they"); hash.Add("6", "are"); hash.Add("7", "paranoid"); hash.Add("8", "but");
            hash.Add("9", "because"); hash.Add("10", "they"); hash.Add("11", "keep"); hash.Add("12", "putting"); hash.Add("13", "themselves");
            hash.Add("14", "deliberately"); hash.Add("15", "into"); hash.Add("16", "paranoid"); hash.Add("17", "avoidable"); hash.Add("18", "situations");
            
            
            WriteLine("\nNote :\n\n\tType 19 If want to Exit\n\n\tType 000 to Display the frequency of words in a large paragraph phrase\n");
            WriteLine("Enter the number to Find the frequency of words (0-18) Then Press Enter : \n");


            string indexhash;
            indexhash = Console.ReadLine();

            switch (indexhash)

            {

                case "000":


                    WriteLine("\nParanoids are not paranoid because they are paranoid but because"+ "\nthey keep putting themselves deliberately into paranoid avoidable situations");
                    ReadLine();
                    break;


                case "0":

                    string hash0 = hash.Get("0");
                    WriteLine("\n0 index value: " + hash0);
                    ReadLine();
                    break;



                case "1":
                    string hash1 = hash.Get("1");
                    WriteLine("\n1st index value: " + hash1);
                    ReadLine();
                    break;

                case "2":
                    string hash2 = hash.Get("2");
                    WriteLine("\n2th index value: " + hash2);
                    ReadLine();
                    break;

                case "3":
                    string hash3 = hash.Get("3");
                    WriteLine("\n3rd index value: " + hash3);
                    ReadLine();
                    break;


                case "4":
                    string hash4 = hash.Get("4");
                    WriteLine("\n4th index value: " + hash4);
                    ReadLine();
                    break;

                case "5":
                    string hash5 = hash.Get("5");
                    WriteLine("\n5th index value: " + hash5);
                    ReadLine();
                    break;

                case "6":
                    string hash6 = hash.Get("6");
                    WriteLine("\n6th index value: " + hash6);
                    ReadLine();
                    break;

                case "7":
                    string hash7 = hash.Get("7");
                    WriteLine("\n7th index value: " + hash7);
                    ReadLine();
                    break;

                case "8":
                    string hash8 = hash.Get("8");
                    WriteLine("\n8th index value: " + hash8);
                    ReadLine();
                    break;

                case "9":
                    string hash9 = hash.Get("9");
                    WriteLine("\n9th index value: " + hash9);
                    ReadLine();
                    break;

                case "10":
                    string hash10 = hash.Get("10");
                    WriteLine("\n10th index value: " + hash10);
                    ReadLine();
                    break;

                case "11":
                    string hash11 = hash.Get("11");
                    WriteLine("\n11th index value: " + hash11);
                    ReadLine();
                    break;

                case "12":
                    string hash12 = hash.Get("12");
                    WriteLine("\n12th index value: " + hash12);
                    ReadLine();
                    break;

                case "13":
                    string hash13 = hash.Get("13");
                    WriteLine("\n13th index value: " + hash13);
                    ReadLine();
                    break;

                case "14":
                    string hash14 = hash.Get("14");
                    WriteLine("\n14th index value: " + hash14);
                    ReadLine();
                    break;

                case "15":
                    string hash15 = hash.Get("15");
                    WriteLine("\n15th index value: " + hash15);
                    ReadLine();
                    break;

                case "16":
                    string hash16 = hash.Get("16");
                    WriteLine("\n16th index value: " + hash16);
                    ReadLine();
                    break;

                case "17":
                    string hash17 = hash.Get("17");
                    WriteLine("\n17th index value: " + hash17);
                    ReadLine();
                    break;

                case "18":
                    string hash18 = hash.Get("18");
                    WriteLine("\n18th index value: " + hash18);
                    ReadLine();
                    break;

                case "19":
                    WriteLine("\tgoing to Exit now");
                    ReadLine();
                    System.Environment.Exit(-1);
                    break;



                default:

                    Console.WriteLine("");
                    break;
           }
            MainMenu();
        }
       
    }
 }
            
        
    
