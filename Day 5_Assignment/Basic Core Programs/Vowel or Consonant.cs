using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic_Core_Programs
{
    class Vowel_or_Consonant
    {
        public static void VowelConsonant()
        {
            char ch;
            Console.WriteLine("Program to Check Whether an Alphabet is Vowel or Consonant\n");
            Console.Write("\n\n");
            Console.WriteLine("Note :\n \n'A'E'I'O'U' Are Vowels\n B C D F G H J K L M N PQ R S T V W X Y Z  Are Consonant\n");
            Console.Write("check whether the input alphabet is a vowel or not:\n");
            Console.Write("-----------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input an Alphabet (A-Z or a-z) : ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            int i = ch;
            if (i >= 48 && i <= 57)
            {
                Console.Write("You entered a number, Please enter an alpahbet.");
            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is not a vowel");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
    }