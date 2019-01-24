using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbolCount = new SortedDictionary<char, int>();
            var text = Console.ReadLine();

            foreach (var symbol in text)
            {
                if (!symbolCount.ContainsKey(symbol))
                {
                    symbolCount.Add(symbol, 0);
                }
                symbolCount[symbol]++;
            }

            foreach (var currSymbol in symbolCount)
            {
                Console.WriteLine($"{currSymbol.Key}: {currSymbol.Value} time/s");
            }
        }
    }
}
