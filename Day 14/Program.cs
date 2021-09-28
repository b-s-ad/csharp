using System;
using static System.Console;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            #region linked list

            WriteLine("UC 3\n" +
                "\nAbility to create Linked List by appending 30 and 70 to 56" +
                "\n\n- Node with data 56 is First Created" +
                "\n\n- Next Append 30 to 56" +
                "\n\n- Finally Append 70 to 30" +
                "\n\n-LinkedList Sequence: 56->30->70\n" + "=========================================\n");

            LinkedList list = new LinkedList();
            list.Append(56);
            list.Append(30);
            list.Append(70);
            //list.InsertAtParticularPosition(1, 70);
            
            WriteLine("");
            list.Display();
            ReadLine();
            #endregion
        }
    }
}
