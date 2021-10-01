﻿using System;
using static System.Console;

namespace BST
{
   
        class Program
        {
            static void Main(string[] args)

            {

                Console.WriteLine("BST\n");
                BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);

                binarySearch.Insert(30);
                binarySearch.Insert(70);
                binarySearch.Insert(22);
                binarySearch.Insert(40);
                binarySearch.Insert(60);
                binarySearch.Insert(95);
                binarySearch.Insert(11);
                binarySearch.Insert(65);
                binarySearch.Insert(3);
                binarySearch.Insert(16);
                binarySearch.Insert(63);
                binarySearch.Insert(67);
                WriteLine("");
                binarySearch.Display();
                bool result = binarySearch.IfExists(63, binarySearch);
                //WriteLine(result);
                WriteLine("");
                binarySearch.GetSize();
                ReadLine();
               

            }
        }
    }

