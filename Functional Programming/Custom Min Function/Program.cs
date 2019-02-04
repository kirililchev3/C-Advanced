using System;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Func<int[], int> min = n => n.Min();

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(min(nums));
        }
    }
}
