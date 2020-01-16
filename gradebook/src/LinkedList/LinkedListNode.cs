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
            Console.WriteLine($"LinkedListNode containing {Data} was deleted");
        }
        
        public LinkedListNode<type> PrevNode;
        public LinkedListNode<type> NextNode;
        public LinkedList<type> LinkedList;
        public type Data;
    }
}
