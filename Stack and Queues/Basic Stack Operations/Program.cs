using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>();
            for (int i = 0; i < commands[0] && i < numbers.Length; i++)
            {
              
                stack.Push(numbers[i]);
                
            }

            for (int i = 0; i < commands[1] && stack.Count > 0; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (stack.Contains(commands[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine($"{stack.Min()}");
                }
            }
            
            
            
        }
    }
}
