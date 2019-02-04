using System;
using System.Collections.Generic;
using System.Linq;

namespace Inferno_III
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> active = Enumerable.Range(0, nums.Count).ToList();

            List<int> allInices = new List<int>(active);

            Func<int, int, bool> sumLeft = (b, c) => b == 0 ? nums[b] == c : nums[b] + nums[b - 1] == c;
            Func<int, int, bool> sumRight = (a, b) =>
              a == nums.Count - 1 ? nums[a] == b : nums[a] + nums[a + 1] == b;
            Func<int, int, bool> sumBoth = (a, b) =>
              nums.Count == 1 ? nums[0] == b : a == 0 ? nums[a] + nums[a + 1] == b :
              a == nums.Count - 1 ? nums[a] + nums[a - 1] == b : nums[a - 1] + nums[a] + nums[a + 1] == b;

            string command;
            while ((command = Console.ReadLine()) != "Forge")
            {
                string[] commandArgs = command.Split(';');
                int sum = int.Parse(commandArgs[2]);
                List<int> current = new List<int>();

                switch (commandArgs[1])
                {
                    case "Sum Left":
                        current = allInices.Where(i => sumLeft(i, sum)).ToList();
                        break;
                    case "Sum Right":
                        current = allInices.Where(i => sumRight(i, sum)).ToList();
                        break;
                    case "Sum Left Right":
                        current = allInices.Where(i => sumBoth(i, sum)).ToList();
                        break;
                }

                switch (commandArgs[0])
                {
                    case "Exclude":
                        active.RemoveAll(i => current.Contains(i));
                        break;
                    case "Reverse":
                        active.AddRange(current);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ",nums.Where((item,index) => active.Contains(index))));

        }
    }
}
