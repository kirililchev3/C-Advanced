﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    queue.Enqueue(nums[i]);
                }
            }
            Console.WriteLine(string.Join(", ",queue.ToArray()));

            
            
        }
    }
}
