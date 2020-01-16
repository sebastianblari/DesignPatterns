using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedList<type> : IDisposable
    {
        public LinkedList()
        {
            HeadNode = null;
            TailNode = null;
        }
        ~LinkedList()
        {
            Console.WriteLine($"Linked List was eliminated");
        }
        public void AddToHead(type data)
        {
            LinkedListNode<type> newNode = new LinkedListNode<type>();
            newNode.LinkedList = this;
            newNode.Data = data;
            newNode.PrevNode = HeadNode;
            if ((HeadNode == null) && (TailNode == null))
            {
                HeadNode = newNode;
                TailNode = newNode;
                newNode.PrevNode = null;
                newNode.NextNode = null;
            } 
            else
            {
                newNode.PrevNode = HeadNode;
                HeadNode.NextNode = newNode;
                HeadNode = newNode;
            }
            Count++;
        }

        public void AddToTail(type data)
        {
            LinkedListNode<type> newNode = new LinkedListNode<type>();
            newNode.Data = data;
            newNode.LinkedList = this;
            newNode.PrevNode = HeadNode;
            if ((HeadNode == null) && (TailNode == null))
            {
                HeadNode = newNode;
                TailNode = newNode;
                newNode.PrevNode = null;
                newNode.NextNode = null;
            }
            else
            {
                newNode.NextNode = TailNode;
                TailNode.PrevNode = newNode;
                TailNode = newNode;
            }
            Count++;
        }

        public void Insert(int index, type data)
        {
            LinkedListNode<type> newNode = new LinkedListNode<type>();
            newNode.LinkedList = this;
            LinkedListNode<type> localNode = TailNode;
            switch (index) 
            {
                case var i when i == 0:
                    AddToTail(data);   
                    break;
                case var i when i == Count + 1:
                    AddToHead(data);
                    break;
                case var i when i < 0:
                    throw new ArgumentException($"Index must be a natural number");
                    break;
                case var i when i > Count + 1:
                    throw new ArgumentException($"Index can't be greater than Count + 1");
                    break;
                default:
                    for (int j = 0; j < Count; j++)
                    {
                        if( j == index)
                        {
                            localNode.PrevNode.NextNode = newNode;
                            localNode.PrevNode = newNode;
                            newNode.NextNode = localNode;

                        }
                        localNode = localNode.NextNode;
                    }
                    Count++;
                    break;



            }
        }

        public void Remove(type data)
        {
            LinkedListNode<type> localLinkedListNode = TailNode;
            while (!EqualityComparer<type>.Default.Equals(localLinkedListNode.Data, data))
            {
                localLinkedListNode = localLinkedListNode.NextNode;
            }
            this.Remove(localLinkedListNode);
        }

        public void Remove(LinkedListNode<type> localLinkedListNode)
        {
            if (Count == 1)
            {
                TailNode = null;
                HeadNode = null;
            }
            else
            {
                switch (localLinkedListNode)
                {
                    case var node when node == TailNode:
                        TailNode = localLinkedListNode.NextNode;
                        localLinkedListNode.NextNode.PrevNode = null;
                        break;
                    case var node when node == HeadNode:
                        HeadNode = localLinkedListNode.PrevNode;
                        localLinkedListNode.PrevNode.NextNode = null;
                        break;
                    default:
                        localLinkedListNode.PrevNode.NextNode = localLinkedListNode.NextNode;
                        localLinkedListNode.NextNode.PrevNode = localLinkedListNode.PrevNode;
                        break;
                }
            }
            
            Count--;
        }

        public void PrintLinkedList()
        {
            LinkedListNode<type> localNode = TailNode;
            for (int index = 0; index < Count; index++)
            {
                Console.WriteLine(localNode.Data);
                localNode = localNode.NextNode;
            }
        }
        public LinkedListNode<type> GetHead()
        {
            return HeadNode;
        }

        public LinkedListNode<type> GetTail()
        {
            return TailNode;
        }

        private LinkedListNode<type> HeadNode;
        private LinkedListNode<type> TailNode;
        public int Count;
    }
}
