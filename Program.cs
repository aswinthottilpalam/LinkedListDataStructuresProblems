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
            list.Add(70);
            Console.WriteLine("The list before inserting 30 is: ");
            list.Display();
            list.InsertAtParticularPosition(2, 30);
            Console.WriteLine("The list after inserting 30 is: ");
            list.Display();
            list.RemoveFirstElement();
            Console.WriteLine("The list after removing first element is : ");
            list.Display();
        }
    }
}
