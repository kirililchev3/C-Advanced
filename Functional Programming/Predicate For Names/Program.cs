using System;
using System.Linq;

namespace Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Predicate<string> filter = x => x.Length <= nameLength;
            Func<string, bool> filterFunc = x => filter(x);

            names = names.Where(filterFunc).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine,names));
        }
    }
}
