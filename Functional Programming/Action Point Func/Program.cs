using System;
using System.Linq;

namespace Action_Point_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = x => Console.WriteLine(x);

            Console.ReadLine().Split().ToList().ForEach(print);
        }
    }
}
