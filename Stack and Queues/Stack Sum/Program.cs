using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(numbers);

            while (true)
            {

                string[] tokens = Console.ReadLine().Split();
                var command = tokens[0].ToLower();
                if (command == "end")
                {
                    break;
                }

                if (command == "add")
                {

                    stack.Push(int.Parse(tokens[1]));
                    stack.Push(int.Parse(tokens[2]));

                }
                else if (command == "remove")
                {
                    int countOfnUmForRemove = int.Parse(tokens[1]);
                    if (countOfnUmForRemove > stack.Count)
                    {
                        continue;
                    }

                    for (int i = 0; i < countOfnUmForRemove; i++)
                    {
                        stack.Pop();
                    }
                }
            }
            var sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}