using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse);
            int delimiter = int.Parse(Console.ReadLine());

            Predicate<int> filter = x => x % delimiter != 0;
            Func<int, bool> filterFunc = x => filter(x);

            nums = nums.Where(filterFunc);

            Console.WriteLine(string.Join(" ",nums.Reverse()));

        }
    }
}
