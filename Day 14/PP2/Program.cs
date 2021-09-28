using DataStructure.QueueUsingLinkedList;
using DataStructure.StackUsingLinkedList;
using System;
using static System.Console;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args) //Section 2 // UC 4
        {

            /*  #region
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

              linkedListStack.Peek(); //top.data
              linkedListStack.Pop();
              linkedListStack.IsEmpty();
              linkedListStack.Display();
              ReadLine();
              #endregion stackcode
  

            #region  Queue link
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            WriteLine("\n");
            linkedListQueue.Display();// this.top=this.top.next
            ReadLine();
            #endregion
*/

            //DeQueue link
            #region  
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            WriteLine("\n");
            linkedListQueue.Display();// this.top=this.top.next
            WriteLine("");
            ReadKey();
            linkedListQueue.Dequeue();
            ReadKey();
            linkedListQueue.Display();
            ReadLine();
            #endregion

        }

    }
}