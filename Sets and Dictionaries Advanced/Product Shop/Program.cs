using System;
using System.Collections.Generic;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var shopProducts = new SortedDictionary<string, Dictionary<string, double>>();
            string line = Console.ReadLine();
            while (line != "Revision")
            {
                string[] commands = line.Split(", ",StringSplitOptions.RemoveEmptyEntries);
                string shop = commands[0];
                string product = commands[1];
                double price = double.Parse(commands[2]);
                if (!shopProducts.ContainsKey(shop))
                {
                    shopProducts[shop] = new Dictionary<string, double>();
                }

                if (!shopProducts[shop].ContainsKey(product))
                {
                    shopProducts[shop].Add(product, price);
                }

                line = Console.ReadLine();
            }

            foreach (var kvp in shopProducts)
            {
                
                Console.WriteLine($"{kvp.Key}-> ");

                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
                
            }
        }

        
    }
}
