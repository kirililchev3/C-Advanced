using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>(orders);
            int sum = 0;

            Console.WriteLine(queue.Max());
            if (queue.Sum() <= quantity)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                for (int i = 0; i <orders.Length; i++)
                {
                    sum += orders[i];
                    
                    if (sum > quantity)
                    {
                        break;
                    }

                    queue.Dequeue();

                }
                Console.WriteLine($"Orders left: {string.Join(" ",queue.ToArray())}");
            }
            
        }
    }
}
