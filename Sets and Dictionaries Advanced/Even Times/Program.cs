using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var evenTimes = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                
                if (!evenTimes.ContainsKey(num))
                {
                    evenTimes.Add(num,1);
                }
                evenTimes[num]++;
            }

            foreach (var kvp in evenTimes)
            {

                if (kvp.Value % 2 != 0)
                {
                    Console.WriteLine(kvp.Key);
                }

            }
            
            
        }
    }
}
