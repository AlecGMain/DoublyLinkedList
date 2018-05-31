using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> myList = new DoublyLinkedList<int>();

            /*myList.AddToFront(5);
            myList.AddToEnd(3);
            myList.AddAt(1, 1);
            myList.RemoveFromEnd();
            myList.RemoveFromFront();*/

            for (int i = 0; i < 10; i++)
            {
                myList.AddToEnd(i + 1);
            }

            for (int i = 0; i < 5; i++)
            {
                myList.RemoveFromEnd();
            }

            for (int i = 0; i < 5; i++)
            {
                myList.RemoveAt(myList.Count - 1);
            }

        }
    }
}
