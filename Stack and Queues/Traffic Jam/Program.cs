using System;
using System.Collections.Generic;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfCarsToPass = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            int counter = 0;
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    int min = Math.Min(numbersOfCarsToPass, queue.Count);
                    for (int i = 0; i < min; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        counter++;
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
