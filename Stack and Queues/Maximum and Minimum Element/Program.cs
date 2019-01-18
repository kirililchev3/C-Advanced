using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<long>();
            for (int i = 1; i <= n; i++)
            {
                int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
                switch (commands[0])
                {
                    case 1:
                        int numToPush = commands[1];
                        stack.Push(numToPush);
                        break;
                    case 2:
                        if (stack.Count == 0)
                        {
                            continue;
                        }
                        else
                        {
                            stack.Pop();
                        }

                        break;
                    case 3:
                        Console.WriteLine(stack.Max());
                        break;
                    case 4:
                        Console.WriteLine(stack.Min());
                        break;
                }

            }
            Console.WriteLine(string.Join(", ",stack.ToArray()));
        }
    }
}
