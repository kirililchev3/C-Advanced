using System;
using System.IO;

namespace Lines_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"../../../text.txt"))
            {
                int counter = 1;

                using (var writer = new StreamWriter(@"../../../output.txt"))
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        int letterCount = 0;
                        int symbolCount = 0;
                        if (counter != 1)
                        {
                            writer.WriteLine();
                        }
                        foreach (var charr in line)
                        {
                            if (char.IsLetter(charr))
                            {
                                letterCount++;
                            }
                            else if (char.IsPunctuation(charr))
                            {
                                symbolCount++;
                            }
                        }

                        writer.Write($"Line {counter}: {line}({letterCount})({symbolCount})");
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
