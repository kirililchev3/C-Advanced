using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Console.ReadLine();
            var extensions = new SortedDictionary<string, Dictionary<string, double>>();
            DirectoryInfo directorySelected = new DirectoryInfo(directory);
            FileInfo[] whole = directorySelected.GetFiles();

            GetFileExtensions(extensions, whole);

            GroupAndWrite(extensions);
        }

        private static void GroupAndWrite(SortedDictionary<string, Dictionary<string, double>> extensions)
        {
            var orderedExtension = extensions.OrderByDescending(p => p.Value.Count)
                 .ThenBy(ext => ext.Key);
            using (var destination = new StreamWriter(@"C:\Users\kiro\Desktop\text.txt"))
            {
                foreach (var item in orderedExtension)
                {
                    destination.WriteLine(item.Key);
                    var orderedDic = item.Value.OrderBy(f => f.Value);
                    foreach (var output in orderedDic)
                    {
                        destination.WriteLine("{0}{1}kb", output.Key, output.Value / 1024);
                    }
                }
            }
        }

        private static void GetFileExtensions(SortedDictionary<string, Dictionary<string, double>> extensions, FileInfo[] whole)
        {
            foreach (var n in whole)
            {
                if (!extensions.ContainsKey(n.Extension))
                {
                    extensions.Add(n.Extension, new Dictionary<string, double> { { string.Format("--{0} - ", n.Name), n.Length } });
                }
                else
                {
                    extensions[n.Extension].Add(string.Format("--{0} - ", n.Name), n.Length);
                }
            }

        }


    }
}
