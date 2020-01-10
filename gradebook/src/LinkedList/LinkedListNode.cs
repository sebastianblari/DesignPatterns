using System;
//using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedListNode<type>
    {
        public LinkedListNode()
        {
        }
        ~LinkedListNode()
        {
        }
        public LinkedListNode<type> PrevNode;
        public LinkedListNode<type> NextNode;
        public LinkedList<type> LinkedList;
        public type Data;
    }
}
