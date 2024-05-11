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
            this.Value = value;
            this.Next = null;
        }

        public Node(int value, Node<T> next)
        {
            this.Value = value;
            this.Next = next;
        }
    }
}
