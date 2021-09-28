using System;
using static System.Console;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            #region linked list

            WriteLine("UC 2\n" +
                "\nAbility to create Linked List by adding 30 and 56 to 70"+
                "\n\n-Node with data 70 is First Created" +
                "\n\n-Next 30 is added to 70" +
                "\n\n-Finally 56 is added to 30" +
                "\n\n-LinkedList Sequence: 56->30->70\n" + "=========================================\n");

            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //list.InsertAtParticularPosition(1, 70);
            
            WriteLine("");
            list.Display();
            Console.ReadKey();
            #endregion
        }
    }
}
