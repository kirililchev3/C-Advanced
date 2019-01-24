using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            Dictionary<double, int> countNums = new Dictionary<double, int>();
            foreach (var num in numbers)
            {
                if (countNums.ContainsKey(num))
                {
                    countNums[num]++;
                }
                else
                {
                    countNums[num] = 1;
                }
            }

            foreach (var kvp in countNums)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
