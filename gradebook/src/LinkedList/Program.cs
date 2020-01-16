using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList<int> intList = new LinkedList<int>();
            //intList.AddToHead(1);
            //intList.AddToHead(2);
            //intList.AddToHead(3);
            //intList.AddToHead(4);
            //intList.AddToTail(0);
            //intList.AddToTail(-1);
            //intList.AddToTail(-2);
            //intList.AddToTail(-3);
            //intList.AddToTail(-4);
            //intList.PrintLinkedList();
            //intList.Remove(intList.GetTail());
            //intList.Remove(intList.GetHead());
            //intList.Remove(0);
            //intList.PrintLinkedList();

            Stack<string> playList = new Stack<string>();
            playList.Push("Wash it all away");
            playList.Push("This means war");
            playList.Push("Nothing else matters");
            Console.WriteLine(playList.Pop());
            Console.WriteLine(playList.Pop());
            Console.WriteLine(playList.Pop());
            playList.Push("Wash it all away");
            playList.Push("This means war");
            playList.Push("Nothing else matters");
            Console.WriteLine("Bye");

            //Queue<string> playList = new Queue<string>();
            //playList.Add("Wash it all away");
            //playList.Add("This means war");
            //playList.Add("Nothing else matters");
            //Console.WriteLine(playList.Remove());
            //Console.WriteLine(playList.Remove());
            //Console.WriteLine(playList.Remove());
            //Console.WriteLine("Bye");
        }
    }
}
