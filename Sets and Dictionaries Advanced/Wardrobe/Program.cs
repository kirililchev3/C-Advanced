using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var clothes = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                var color = clothes[0];
                var clothesSplit = clothes[1].Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int j = 0; j < clothesSplit.Length; j++)
                {
                    if (wardrobe.ContainsKey(color) == false)
                    {
                        wardrobe.Add(color, new Dictionary<string, int>());
                        if (wardrobe[color].ContainsKey(clothesSplit[j]) == false)
                        {
                            wardrobe[color].Add(clothesSplit[j], 1);
                        }
                    }
                    else
                    {
                        //wardrobe[color].Add(clothesSplit[j], 1);
                        if (wardrobe[color].ContainsKey(clothesSplit[j]) == false)
                        {
                            wardrobe[color].Add(clothesSplit[j], 1);
                        }
                        else
                        {
                            wardrobe[color][clothesSplit[j]]++;
                        }
                    }
                }
            }

            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var neededColor = input[0];
            var neededClothing = input[1];

            if (wardrobe.ContainsKey(neededColor))
            {
                if (wardrobe[neededColor].ContainsKey(neededClothing))
                {
                    foreach (var kvp in wardrobe)
                    {
                        var color = kvp.Key;

                        Console.WriteLine($"{color} clothes:");

                        foreach (var item in kvp.Value)
                        {
                            if (color == neededColor && item.Key == neededClothing)
                            {
                                Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                            }
                            else
                            {
                                Console.WriteLine($"* {item.Key} - {item.Value}");
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var kvp in wardrobe)
                {
                    var color = kvp.Key;

                    Console.WriteLine($"{color} clothes:");

                    foreach (var item in kvp.Value)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
