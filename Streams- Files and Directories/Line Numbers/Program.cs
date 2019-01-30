using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"Resources\02. Line Numbers\Input.txt"))
            {
                string line = reader.ReadLine();
                int counter = 1;
                using (var writer = new StreamWriter(@"Resources\02. Line Numbers\Output.txt"))
                {
                    while (line != null)
                    {
                        writer.WriteLine($"{counter}. {line}");
                        line = reader.ReadLine();
                        counter++;
                    }
                    

                }
            }
        }
    }
}
