using System;
using System.Collections.Generic;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var parentheses = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    parentheses.Push(input[i]);
                }
                else
                {
                    if (parentheses.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    if (input[i] == ')')
                    {
                        var lastParenteses = parentheses.Pop();
                        if (lastParenteses != '(')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    else if (input[i] == ']')
                    {
                        var lastParenteses = parentheses.Pop();
                        if (lastParenteses != '[')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                    if (input[i] == '}')
                    {
                        var lastParenteses = parentheses.Pop();
                        if (lastParenteses != '{')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                    }
                }
            }
            if (parentheses.Count == 0)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
