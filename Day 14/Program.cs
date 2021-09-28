using System;
using static System.Console;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            #region linked list

            WriteLine("UC 8\n" +
                "\nAbility to insert 40 after 30 to" +
                "\nthe Linked List sequence of" +
                "\n56->30->70" +
                "- Search LinkedList to get Node with key value 30\n- Then Insert 40 to 30" +
                "\n- Final Sequence: 56->30->40->70" +
                "\n=========================================\n");

            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            ReadKey();
            //list.InsertAtParticularPosition(2, 30);
            WriteLine("");
            list.Search(30);
            list.Display();
            ReadKey();                    
            list.InsertAtParticularPosition(4, 40);
            WriteLine("");
            list.InsertAtParticularPosition(1, 56);
            WriteLine("");            
            ReadKey();
            list.Display();
            ReadLine();
            #endregion
        }

    }

}