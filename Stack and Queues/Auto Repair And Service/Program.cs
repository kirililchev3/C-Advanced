using System;
using System.Collections.Generic;

namespace Auto_Repair_And_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vehicles = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            var queue = new Queue<string>(vehicles);
            var servedVehicles = new Stack<string>();
            string[] command = Console.ReadLine().Split('-');
            while (command[0] != "End")
            {
                if (command[0] == "Service")
                {
                    if (queue.Count > 0)
                    {
                        string car = queue.Dequeue();
                        Console.WriteLine($"Vehicle {car} got served.");
                        servedVehicles.Push(car);
                    }
                }
                else if (command[0] == "CarInfo")
                {
                    string checkCar = command[1];
                    if (servedVehicles.Contains(checkCar))
                    {
                        Console.WriteLine("Served.");
                    }
                    else
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                }
                else if (command[0] == "History")
                {
                    if (servedVehicles.Count > 0)
                    {
                        Console.WriteLine($"{string.Join(", ",servedVehicles.ToArray())}");
                    }
                }
                command = Console.ReadLine().Split('-');
            }

            if (queue.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ",queue.ToArray())}");
            }

            if (servedVehicles.Count > 0)
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ",servedVehicles.ToArray())}");
            }
          

        }
    }
}
