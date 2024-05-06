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

        private Node<T> SortLinkedList(int count)
        {
            Node<T> _current = Head;
            Node<T> _previous = _current;

            Node<T> _min = _current;
            Node<T> _minPrevious = _min;

            Node<T> _sortedListHead = null;
            Node<T> _sortedListTail = _sortedListHead;

            for (int i = 0; i < count; i++)
            {
                _current = Head;
                _min = _current;
                _minPrevious = _min;

                while (_current != null)
                {
                    if (_current.Value < _min.Value)
                    {
                        _min = _current;
                        _minPrevious = _previous;
                    }
                    _previous = _current;
                    _current = _current.Next;
                }

                if (_min == Head)
                {
                    Head = Head.Next;
                }
                else if (_min.Next == null)
                {
                    _minPrevious.Next = null;
                }
                else
                {
                    _minPrevious.Next = _minPrevious.Next.Next;
                }

                if (_sortedListHead != null)
                {
                    _sortedListTail.Next = _min;
                    _sortedListTail = _sortedListTail.Next;
                }
                else
                {
                    _sortedListHead = _min;
                    _sortedListTail = _sortedListHead;
                }
            }

            return _sortedListHead;
        }
    }
}
