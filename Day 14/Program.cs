using System;
using static System.Console;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            #region linked list

            WriteLine("UC 4\n" +
                "\nAbility to insert 30 between 56 and 70" +
                "\n- Final Sequence: 56->30->70" 
                 + "\n=========================================\n");

            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.InsertAtParticularPosition(2, 30);
            
            WriteLine("");
            list.Display();
            ReadLine();
            #endregion
        }
    }
}
