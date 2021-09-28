using System;
using static System.Console;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            #region linked list

            WriteLine("UC 9\n" +
                "\nAbility to delete 40 from the Linked" +
                "\nList sequence of 56->30->40->70" +
                "\nand show the size of LinkedList is 3" +
                "\n- Search LinkedList to find node with key value 40\n- Delete the node" +
                "\n- Final Sequence: 56->30->70" +
                "\n=========================================\n");

            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            ReadKey();
            //list.InsertAtParticularPosition(2, 30);
            WriteLine("");
            list.Search(30);
            
            
            list.InsertAtParticularPosition(4, 40);
            WriteLine("");
            list.InsertAtParticularPosition(1, 56);
            
            WriteLine("");
            ReadKey();
            list.Display();
        
            list.Search(40);
            WriteLine("");
            list.RemoveFirstNode();
            list.InsertAtParticularPosition(1, 56);
            list.InsertAtParticularPosition(2, 30);
            WriteLine("");
            ReadKey();
            list.Display();
            ReadLine();
            #endregion
        }

    }

}