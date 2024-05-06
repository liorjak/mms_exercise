using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ex3;

namespace ex3
{
    class LinkedList<T>
    {
        public Node<T> Head { get; set; }

        private void Append(int value)
        {
            if (Head.Next == null)
            {
                Head.Next.Value = value;
            }
            else
            {
                Node<T> node = new Node<T>(value);
                node.Next = Head.Next;
                Head.Value = node.Value;
            }
            Head.Next.Next = null;
        }

        private void Prepend(int value)
        {
            Head.Value = value;
        }

        private int Pop()
        {
            int value;
            value = Head.Value;
            Head.Next = Head.Next;
            return value;
        }

        private int Unqueue()
        {
            int value;
            value = Head.Value;
            Head.Next = Head.Next;
            return value;
        }

        private IEnumerator<int> ToList()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        private bool isCircular()
        {
            if (Head.Next == null)
            {
                return true;
            }

            Node<T> node = Head.Next;

            while (node != null && node != Head.Next)
            {
                node = node.Next;
            }

            return (node == Head.Next);
        }
    }
}
