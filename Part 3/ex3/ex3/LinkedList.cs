using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ex3;

namespace ex3
{
    class LinkedList<T>
    {
        public Node<int> Head { get; set; }

        private void Append(int value)
        {
            if (Head.Next == null)
            {
                Head.Next.Value = value;
            }
            else
            {
                Node<int> node = new Node<int>(value);
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

        public IEnumerator<T> ToList()
        {
            foreach (Node<T> item in Nodes)
            {
                yield return item.data;
            }
        }


        private bool isCircular()
        {
            if (Head.Next == null)
            {
                return true;
            }

            Node<int> node = Head.Next;

            while (node != null && node != Head.Next)
            {
                node = node.Next;
            }

            return (node == Head.Next);
        }
    }
}
