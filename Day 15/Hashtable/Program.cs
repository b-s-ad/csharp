
using System;
using System.Collections.Generic;
using static System.Console;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hash table UC 1"); 
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");


            string hash0 = hash.Get("0");
            WriteLine("\n000 index value: " + hash0);

            string hash1 = hash.Get("1");
            WriteLine("1st index value: " + hash1);

            string hash2 = hash.Get("2");
            WriteLine("2th index value: " + hash2);

            string hash3 = hash.Get("3");
            WriteLine("3rd index value: " + hash3);
            
            string hash4 = hash.Get("4");
            WriteLine("4th index value: " + hash4);
            
            string hash5 = hash.Get("5");
            WriteLine("5th index value: " + hash5);
            ReadKey();


        }
    }
}