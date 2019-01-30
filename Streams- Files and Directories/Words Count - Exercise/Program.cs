using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Words_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            using (var wordReader = new StreamReader(@"../../../words.txt"))
            {
                string line;
                while ((line = wordReader.ReadLine()) != null)
                {
                    string[] splitedLine = line.Split(" "
                        ,StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.ToLower())
                        .ToArray();
                    words.AddRange(splitedLine);
                }
            }

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordsCount.ContainsKey(word))
                {
                    wordsCount[word] = 0;
                }
            }

            using (var reader = new StreamReader(@"../../../text.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string symbols = " ";
                    foreach (var charr in line)
                    {
                        if (char.IsPunctuation(charr) && charr != '\'')
                        {
                            symbols += charr;
                        }
                    }
                    string[] splitedLine = line.ToLower().Split(symbols.ToCharArray()
                        , StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in splitedLine)
                    {
                        if (wordsCount.ContainsKey(word))
                        {
                            wordsCount[word]++;
                        }
                    }
                }
            }

            var sortedDictionary = wordsCount
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);

            using (var resultReader = new StreamReader(@"../../../expectedResult.txt"))
            {
                bool isSame = true;
                
                foreach (var kvp in sortedDictionary)
                {
                    string output = $"{kvp.Key} - {kvp.Value}";
                    string line = resultReader.ReadLine();
                    if (output != line)
                    {
                        isSame = false;
                        break;
                    }
                }
                if (isSame)
                {
                    Console.WriteLine(true);
                }
 
            }
            using (var writer = new StreamWriter(@"../../../actualResult.txt"))
            {
                foreach (var kvp in sortedDictionary)
                {
                    string output = $"{kvp.Key} - {kvp.Value}";
                    writer.WriteLine(output);
                }
            }

            
        }
    }
}
