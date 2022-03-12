using System;

namespace LinkedListPgm
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Operations");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
        }
    }
}
