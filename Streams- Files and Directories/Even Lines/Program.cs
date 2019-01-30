using System;
using System.Collections.Generic;
using System.IO;

namespace Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string specialSymbols = "-.,!?";
            int counter = 0;

            using (var reader = new StreamReader(@"../../../text.txt"))
            {
                var line = reader.ReadLine();

                using (var writer = new StreamWriter(@"../../../output.txt"))
                {
                    while (line != null)
                    {
                       
                        if (counter % 2 == 0)
                        {
                            if (counter != 0)
                            {
                                writer.WriteLine();
                            }
                            string changedLine = string.Empty;
                            foreach (var charr in line)
                            {
                                if (specialSymbols.Contains(charr))
                                {
                                    changedLine += '@';
                                }
                                else
                                {
                                    changedLine += charr;
                                }
                            }

                            string[] splitedLine = changedLine.Split();

                            Array.Reverse(splitedLine);
                            writer.WriteLine(string.Join(" ", splitedLine));
                        }
                        counter++;
                        line = reader.ReadLine();
                        
                    }
                }
            }
        }
    }
}
