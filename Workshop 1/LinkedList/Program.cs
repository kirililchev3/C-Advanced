using System;

namespace LinkedList
{
   public class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new DoublyLinkedList();

            linkedList.AddHead(5);
            linkedList.AddHead(10);
            linkedList.AddHead(15);

            Console.WriteLine((int)linkedList.Head == 15);
            Console.WriteLine((int)linkedList.Tail == 5);
            Console.WriteLine(linkedList.Count == 3);

            linkedList.AddTail(20);
            linkedList.AddTail(25);

            linkedList.ForEach(Console.WriteLine);

            var arr = linkedList.ToArray();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine((int)linkedList.Head == 15);
            Console.WriteLine((int)linkedList.Tail == 25);
            Console.WriteLine(linkedList.Count == 5);

            Console.WriteLine((int)linkedList.RemoveFirst() == 15);
            Console.WriteLine((int)linkedList.RemoveFirst() == 10);
            Console.WriteLine((int)linkedList.Head == 5);
            Console.WriteLine(linkedList.Count == 3);

            Console.WriteLine((int)linkedList.RemoveLast() == 25);
            Console.WriteLine((int)linkedList.RemoveLast() == 20);
            Console.WriteLine((int)linkedList.RemoveLast() == 5);
            Console.WriteLine(linkedList.Count == 0);

            try
            {
                Console.WriteLine(linkedList.Head);
                Console.WriteLine(false);
            }
            catch (InvalidOperationException)
            {

                Console.WriteLine(true);
            }

            

            

            
            
            
        }
    }
}
