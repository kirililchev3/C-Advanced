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
            Car[] cars = new Car[count];

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                int speed = int.Parse(tokens[1]);
                int power = int.Parse(tokens[2]);
                int weight = int.Parse(tokens[3]);
                string type = tokens[4];
                double tyre1pressure = double.Parse(tokens[5]);
                int tyre1age = int.Parse(tokens[6]);
                double tyre2pressure = double.Parse(tokens[7]);
                int tyre2age = int.Parse(tokens[8]);
                double tyre3pressure = double.Parse(tokens[9]);
                int tyre3age = int.Parse(tokens[10]);
                double tyre4pressure = double.Parse(tokens[11]);
                int tyre4age = int.Parse(tokens[12]);

                cars[i] = new Car(model, new Engine(speed, power), new Cargo(type, weight),
                    new List<Tyre>{new Tyre(tyre1pressure, tyre1age), new Tyre (tyre2pressure, tyre2age),
                    new Tyre(tyre3pressure, tyre3age),new Tyre(tyre4pressure, tyre4age) });
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(c => c.cargo.type == "fragile")
                    .Where(c => c.tires.Any(t => t.pressure < 1))
                    .Select(c => c.model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
            else if (command == "flamable")
            {
                cars.Where(c => c.cargo.type == "flamable")
                    .Where(c => c.engine.power > 250)
                    .Select(c => c.model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
        }
    }
}
