using System;
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
            if(Head.Value == null)
            {
                Head.Value = value;
            }
            else
            {
                Node<int> node = new Node<int>(value);
                node.Next = Head.Next;
                Head.Value = node.Value;
            }
        }

        private void Prepend(int value)
        {
            Head.Value = value;
        }
    }
}
