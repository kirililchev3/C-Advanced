using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split().Distinct().Select(int.Parse).ToList();

            List<Predicate<int>> predicates = new List<Predicate<int>>();
            dividers.ForEach(d => predicates.Add(x => x % d == 0));
            List <int> result = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                bool isDivisible = true;

                foreach (var predicate in predicates)
                {
                    if (!predicate(i))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
