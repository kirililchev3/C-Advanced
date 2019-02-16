using System;
using System.Reflection;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Family family = new Family();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                family.AddMember(new Person(name, age));
            }

            Person oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");





        }
    }
}
