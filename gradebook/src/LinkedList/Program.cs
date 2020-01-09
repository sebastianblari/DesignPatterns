using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> intList = new LinkedList<int>();
            intList.AddToHead(1);
            intList.AddToHead(2);
            intList.AddToHead(3);
            intList.AddToHead(4);
            intList.AddToTail(0);
            intList.AddToTail(-1);
            intList.AddToTail(-2);
            intList.AddToTail(-3);
            intList.AddToTail(-4);
            intList.PrintLinkedList();
            intList.Remove(0);
            intList.PrintLinkedList();
            intList.Insert(4, 0);
            intList.PrintLinkedList();
        }
    }
}
