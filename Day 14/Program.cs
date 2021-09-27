using System;
using static System.Console;
namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            #region linked list
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //list.InsertAtParticularPosition(2, 30);
            WriteLine("");
            list.Display();
            Console.ReadKey();
            #endregion
        }
    }
}
