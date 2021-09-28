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
                "\nAbility to delete the Last element in the LinkedList of sequence 56->30->70" +
                "\n- Write pop method "//pop (RemoveLastNode) = remove/delete 
                + "\n- Note there is new tail" +
                "\n- Final Sequence: 56->30"
                 + "\n=========================================\n");

            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //list.InsertAtParticularPosition(2, 30);
            list.RemovaLastNode();
            WriteLine("");
            ReadKey();
            list.Display();
            ReadLine();
            #endregion
        }
    }
}
