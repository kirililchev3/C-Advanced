using System;
using System.Collections.Generic;
using System.Linq;

namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine,numbers
                .Select(p => $"{p*1.20:F2}")));
               

                
        }

    }
}
