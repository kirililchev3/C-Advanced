using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            
            int count = int.Parse(Console.ReadLine());
            Person[] person = new Person[count];

            for (int i = 0; i < count; i++)
            {
                string personString = Console.ReadLine();
                string[] tokens = personString.Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                person[i] = new Person(name, age);
            }

            List<Person> result = person.OrderBy(p => p.Name).Where(p => p.Age > 30).ToList();


            foreach (var persons in result)
            {
                Console.WriteLine($"{persons.Name} - {persons.Age}");
            }
          

           





        }
    }
}
