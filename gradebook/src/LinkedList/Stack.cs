using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Stack<type> : LinkedList<type>
    {
        public Stack()
        {
        }
        public void Push(type data)
        {
            AddToHead(data);
        }
        public type Pop()
        {
            type data = GetHead().Data;
            Remove(GetHead());
            return data;
        }
    }
}
