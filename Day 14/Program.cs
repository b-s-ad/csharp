using System;
using static System.Console;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            #region linked list

            WriteLine("UC 5\n" +
                "\nAbility to delete the first element in the LinkedList of sequence 56->30->70" +
                "\n- Write pop method "//pop (RemoveFirstNode) = remove/delete 
                + "\n- Note there is new head" +
                "\n- Final Sequence: 30->70" 
                 + "\n=========================================\n");

            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //list.InsertAtParticularPosition(2, 30);
            list.RemoveFirstNode();
            WriteLine("");
            ReadKey();
            list.Display();
            ReadLine();
            #endregion
        }
    }
}
