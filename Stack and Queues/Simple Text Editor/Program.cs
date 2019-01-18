using System;
using System.Collections.Generic;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfOperations = int.Parse(Console.ReadLine());
            var texts = new Stack<string>();
            var text = "";
            texts.Push(text);
            for (int i = 0; i < numOfOperations; i++)
            {
                var input = Console.ReadLine().Split();
                var command = input[0];
                if (command == "1")
                {
                    text += input[1];
                    texts.Push(text);
                }
                else if (command == "2")
                {
                    var count = int.Parse(input[1]);
                    text = text.Substring(0, text.Length - count);
                    texts.Push(text);
                }
                else if (command == "3")
                {
                    var index = int.Parse(input[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (command == "4")
                {
                    if (texts.Count >= 2)
                    {
                        texts.Pop();
                        text = texts.Peek();
                    }
                }
            }
        }
    }
}
