using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nums[0];
            int m = nums[1];
            var firstNumbers = new HashSet<int>();
            var secondNumbers = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                firstNumbers.Add(num);
            }
            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                secondNumbers.Add(num);
            }
            Console.WriteLine(string.Join(" ",firstNumbers.Intersect(secondNumbers)));
            
            

           

        }
    }
}
