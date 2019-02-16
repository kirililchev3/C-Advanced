using System;

namespace DefiningClasses
{
    public class Car
    {
        public string model;
        public decimal fuelAmount;
        public decimal fuelCost;
        public decimal distanceTravelled;

        public Car(string model,decimal fuelAmount,decimal fuelCost)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelCost = fuelCost;
            this.distanceTravelled = 0;
        }

        public void Drive(decimal distance)
        {
            if (this.fuelAmount < distance * this.fuelCost)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.fuelAmount -= distance * this.fuelCost;
                this.distanceTravelled += distance;
            }
        }
    }
}
