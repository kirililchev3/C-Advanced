using System;
using System.Linq;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = x => Console.WriteLine($"Sir {x}");

            Console.ReadLine().Split().ToList().ForEach(print);

        }
    }
}
