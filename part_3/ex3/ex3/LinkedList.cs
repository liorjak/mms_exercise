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

        public void Append(int value)
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

        public void Prepend(int value)
        {
            Head.Value = value;
        }

        public int Pop()
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

        public IEnumerator<int> ToList()
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

        private Node<T> Sort(int count)
        {
            Node<T> current = Head;
            Node<T> previous = current;

            Node<T> min;
            Node<T> max;
            Node<T> minPrevious;

            Node<T> sortedListHead = null;
            Node<T> sortedListTail = sortedListHead;

            for (int i = 0; i < count; i++)
            {
                current = Head;
                min = current;
                minPrevious = min;

                while (current != null)
                {
                    if (current.Value < min.Value)
                    {
                        min = current;
                        minPrevious = previous;
                    }
                    previous = current;
                    current = current.Next;
                }

                if (min == Head)
                {
                    Head = Head.Next;
                }
                else if (min.Next == null)
                {
                    minPrevious.Next = null;
                }
                else
                {
                    minPrevious.Next = minPrevious.Next.Next;
                }

                if (sortedListHead != null)
                {
                    sortedListTail.Next = min;
                    sortedListTail = sortedListTail.Next;
                }
                else
                {
                    sortedListHead = min;
                    sortedListTail = sortedListHead;
                }
            }
            max = sortedListTail;
            min = sortedListHead;
            GetMinNode(min);
            GetMaxNode(max);
            return sortedListHead;
        }

        private Node<T> GetMaxNode(Node<T> maxNode)
        {
            return maxNode;
        }

        private Node<T> GetMinNode(Node<T> minNode)
        {
            return minNode;
        }
    }
}
