using System;
using System.Collections.Generic;
using System.Text;

namespace ex3
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            this.Value = value;
            this.Next = null;
        }
        public Node(int value, Node next)
        {
            this.Value = value;
            this.Next = next;
        }
    }
}
