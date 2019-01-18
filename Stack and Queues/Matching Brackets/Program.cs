using System;
using System.Collections;
using System.Collections.Generic;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == '(')
                {
                    stack.Push(i);
                }
                else if (ch == ')')
                {
                    int startIndex = stack.Pop();
                    int length = i - startIndex + 1;
                    string contents = input.Substring(startIndex, length);
                    Console.WriteLine(contents);
                }
                
            }
            
        }
    }
}
