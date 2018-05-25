﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class DoublyLinkedList<T> where T : IComparable<T>
    {
        public Node<T> Head { get; set; }

        public DoublyLinkedList() 
            : this (null)
        {}

        public DoublyLinkedList(Node<T> head)
        {
            Head = head;
        }

        public void AddToEnd(T value)
        {
            if (Head.Value == null)
            {
                Head.Value = value;
            }
            else
            {
                Node<T> current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next.Value = value;
                current.Next.Previous = current.Next;
                Head = current;
            }
        }
        public void AddToFront(T value)
        {
            if (Head.Value == null)
            {
                Head.Value = value;
            }
            else
            {
                Node<T> tempNode = new Node<T>(value);
                tempNode.Next = Head;
                tempNode.Next.Previous = tempNode;
                Head = tempNode;
            }
        }
        public void AddAt(int position, T value)
        {
            if(Head.Value == null)
            {
                Head.Value = value;
            }
            else
            {
                Node<T> current = Head;
                for(int i = 0; i < position; i++)
                {
                    current = current.Next;
                }
                current.Next.Next = current.Next;
                current.Next.Value = value;
                current.Next.Next.Previous = current.Next;
            }
        }
        public bool RemoveFromFront()
        {
            if (Head != null)
            { 
                Head = Head.Next;
                Head.Previous = null;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveFromEnd()
        {

        }
    }

    

}
