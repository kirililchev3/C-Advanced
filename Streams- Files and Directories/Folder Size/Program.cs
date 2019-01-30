using System;
using System.IO;

namespace Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(@"D:\Programming\Project's\Streams, Files and Directories\Streams, Files and Directories\Folder Size\Resources\06. Folder Size\TestFolder");
            double sum = 0;
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }
            sum = (sum / 1024) / 1024;
            File.WriteAllText(@"D:\Programming\Project's\Streams, Files and Directories\Streams, Files and Directories\Folder Size\Resources\06. Folder Size/TestFolder/Size of Files here in MB.txt", sum.ToString());

        }
    }
}
