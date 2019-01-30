using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keys = File.ReadAllText(@"D:\Programming\Project's\Streams, Files and Directories\Streams, Files and Directories\Word Count\Resources\03. Word Count\words.txt")
                .ToLower().Split();

            string[] text = File.ReadAllText(@"D:\Programming\Project's\Streams, Files and Directories\Streams, Files and Directories\Word Count\Resources\03. Word Count\text.txt")
                .ToLower()
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }
                , StringSplitOptions.RemoveEmptyEntries);

            File.WriteAllLines(@"D:\Programming\Project's\Streams, Files and Directories\Streams, Files and Directories\Word Count\Resources\03. Word Count\KeysCount.txt", KeysCount(keys, text)
                .Select(x => $"{x.Key} - {x.Value}"));
        }

        private static Dictionary<string,int> KeysCount(string[] keys, string[] text)
        {
            Dictionary<string, int> keyCount = new Dictionary<string, int>();
            foreach (var key in keys)
            {
                keyCount[key] = 0;
            }

            foreach (var word in text)
            {
                if (keyCount.ContainsKey(word))
                {
                    keyCount[word]++;
                }
            }

            return keyCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

        }
    }
}
