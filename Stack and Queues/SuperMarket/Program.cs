using System;
using System.Collections.Generic;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                if (command != "Paid")
                {
                    queue.Enqueue(command);
                }
                 else if (command == "Paid")
                {
                    for (int i = queue.Count - 1; i >= 0; i--)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                    
                }

                
                
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
