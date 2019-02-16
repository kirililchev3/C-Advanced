using System;
using System.Reflection;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            var personFirst = new Person();
            personFirst.Name = "Pesho";
            personFirst.Age = 20;

            var personSecond = new Person
            {
                Name = "Gosho",
                Age = 19,
            };

            var personThird = new Person
            {
                Name = "Stamat",
                Age = 43,
            };

            Console.WriteLine(personFirst.GetIformation());
            Console.WriteLine(personSecond.GetIformation());
            Console.WriteLine(personThird.GetIformation());







        }
    }
}
