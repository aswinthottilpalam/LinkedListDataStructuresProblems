using System;

namespace LinkedListPgm
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Operations");
            LinkedList list = new LinkedList();
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();
        }
    }
}
