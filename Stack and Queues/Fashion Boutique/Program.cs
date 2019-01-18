using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacityOfRack = int.Parse(Console.ReadLine());
            var stack = new Stack<int>(clothesInBox);
            int countOfRack = 1;
            int sum = 0;

            while (stack.Count > 0)
            {
                int currentClothValue = stack.Pop();
                if (capacityOfRack - (sum + currentClothValue) > 0)
                {
                    sum += currentClothValue;
                }
                else if (capacityOfRack - (sum + currentClothValue) == 0)
                {
                    if (stack.Count != 0)
                    {
                        countOfRack++;
                        sum = 0;
                    }
                }
                else if (capacityOfRack - (sum + currentClothValue) < 0)
                {
                    stack.Push(currentClothValue);
                    countOfRack++;
                    sum = 0;
                }
            }

            Console.WriteLine(countOfRack);

        }
    }
}

