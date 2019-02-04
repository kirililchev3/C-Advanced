using System;
using System.Collections.Generic;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            Func<List<int>, List<int>> add = x => x.Select(y => y + 1).ToList();
            Func<List<int>, List<int>> multiply = x => x.Select(y => y * 2).ToList();
            Func<List<int>, List<int>> subtract = x => x.Select(y => y - 1).ToList();
            Func<List<int>, string> stringify = x => string.Join(" ",x);

            while ((command = Console.ReadLine()) != "end")
            {
                
                switch (command)
                {
                    case "add":
                        numbers = add(numbers);
                        break;
                    case "multiply":
                        numbers = multiply(numbers);
                        break;
                    case "subtract":
                        numbers = subtract(numbers);
                        break;
                    case "print":
                        Console.WriteLine(stringify(numbers));
                        break;
                    

                }

            }
        }
    }
}
