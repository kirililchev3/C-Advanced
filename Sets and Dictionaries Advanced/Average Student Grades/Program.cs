using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfGrades = int.Parse(Console.ReadLine());
            var studentAndGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < numOfGrades; i++)
            {
                var nameAndGrade = Console.ReadLine().Split();
                string name = nameAndGrade[0];
                double grade = double.Parse(nameAndGrade[1]);

                if (!studentAndGrades.ContainsKey(name))
                {
                    studentAndGrades[name]= new List<double>();
                    
                }
                studentAndGrades[name].Add(grade);
            }

            foreach (var kvp in studentAndGrades)
            {
                var name = kvp.Key;
                var studentsGrades = kvp.Value;
                var average = studentsGrades.Average();
                Console.Write($"{name} -> ");

                foreach (var grade in studentsGrades)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
