using DataStructure.StackUsingLinkedList;
using System;
using static System.Console;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            #region
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            ReadKey();
            list.Display();
            //list.InsertAtParticularPosition(2, 30);
            WriteLine("\n");
            #endregion
        

        #region  stackcode
        LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            WriteLine("\n");
            linkedListStack.Display();
            WriteLine("");
            ReadLine();
            
            //linkedListStack.Peek(); top.data
            //linkedListStack.Pop();
            //linkedListStack.IsEmpty();
            //linkedListStack.Display();
            #endregion stackcode

        }

    }
}