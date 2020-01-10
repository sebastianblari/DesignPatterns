using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Queue<type> : LinkedList<type>
    {
        public Queue()
        {

        }
        public void Add(type data)
        {
            AddToTail(data);
        }

        public type Peek()
        {
            return GetHead().Data;
        }

        public type Remove()
        {
            var data = Peek();
            Remove(GetHead());
            return data;
        }

    }
}
