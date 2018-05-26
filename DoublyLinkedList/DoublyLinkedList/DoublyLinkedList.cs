using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class DoublyLinkedList<T> where T : IComparable<T>
    {
        public Node<T> Head;
        public int Count;
        public DoublyLinkedList()
            : this(null)
        { }

        public DoublyLinkedList(Node<T> head)
        {
            Head = head;
        }

        public void AddToEnd(T value)
        {
            if (Head.Value == null)
            {
                Head = new Node<T>();
                Head.Value = value;
            }
            else
            {
                Node<T> current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node<T>();
                current.Next.Value = value;
                current.Next.Previous = current;
                Head = current;
            }
            Count++;
        }
        public void AddToFront(T value)
        {
            if (Head == null)
            {
                Head = new Node<T>();
                Head.Value = value;
            }
            else
            {
                Node<T> tempNode = new Node<T>(value);
                tempNode.Next = new Node<T>();
                tempNode.Next = Head;
                tempNode.Next.Previous = tempNode;
                Head = tempNode;
            }
            Count++;
        }
        public void AddAt(int position, T value)
        {
            if (Head == null)
            {
                Head = new Node<T>();
                Head.Value = value;
            }
            else
            {
                if(Head == null)
                {
                    Head = new Node<T>();
                    Head.Value = value;
                }
                Node<T> current = Head;
                for (int i = 0; i < position; i++)
                {
                    current = current.Next;
                }
                if(current.Next == null)
                {
                    current.Next = new Node<T>();
                }
                if(current.Next.Next == null)
                {
                    current.Next.Value = value;
                }
                else
                {
                    Node<T> temp = current.Next;
                    current.Next.Value = value;
                    current.Next.Next = temp;
                    current.Next.Next.Previous = current.Next;
                }
                Head = current;
            }
            Count++;
        }
        public bool RemoveFromFront()
        {
            if (Head != null)
            {
                Head = Head.Next;
                Head.Previous = null;
                Count--;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveFromEnd()
        {
            if (Head == null)
            {
                return false;
            }
            else
            {
                Node<T> current = Head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
                Head = current;
                Count--;
                return true;
            }
        }
        public bool RemoveAt(int position)
        {
            if (Head == null)
            {
                return false;
            }
            else
            {
                if (position == 0)
                {
                    this.RemoveFromFront();
                    Count--;
                    return true;
                }
                else
                {
                    int count = 1;
                    Node<T> tester = Head;
                    while (tester.Next != null)
                    {
                        count++;
                        tester = tester.Next;
                    }
                    if (count >= position)
                    {
                        Node<T> current = Head;
                        for (int i = 0; i < position - 1; i++)
                        {
                            current = current.Next;
                        }
                        current.Next = current.Next.Next;
                        current.Next.Previous = current;
                        Head = current;
                        Count--;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public bool IsEmpty()
        {
            return Head == null;
        }


    }
}
