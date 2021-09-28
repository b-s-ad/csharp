using System;
using static System.Console;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            #region linked list

            WriteLine("UC 7\n" +
                "\nAbility to search LinkedList to find Node with value 30" +
                
                  "\n=========================================\n");

            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //list.InsertAtParticularPosition(2, 30);
            WriteLine("");
            list.Search(30);
            ReadKey();
            list.Display();
            ReadLine();
            #endregion
        }
    }
}
