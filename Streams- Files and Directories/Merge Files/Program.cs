using System;
using System.IO;
using System.Linq;

namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allData = File.ReadAllLines
                (@"D:\Programming\Project's\Streams, Files and Directories\Streams, Files and Directories\Merge Files\04. Merge Files\FileOne.txt");
            allData = allData.Concat(File.ReadAllLines(@"D:\Programming\Project's\Streams, Files and Directories\Streams, Files and Directories\Merge Files\04. Merge Files\FileTwo.txt"))
                .ToArray();
            File.WriteAllLines(@"D:\Programming\Project's\Streams, Files and Directories\Streams, Files and Directories\Merge Files\04. Merge Files\ThirdFile.txt"
                , allData.OrderBy(x => x));
        }
    }
}
