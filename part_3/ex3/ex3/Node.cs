using System;
using System.Collections.Generic;
using System.Text;
using ex3;

namespace ex3
{
    class Node<T>
    {
        public int Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }

        public Node(int value, Node<T> next)
        {
            Value = value;
            Next = next;
        }
    }
}
