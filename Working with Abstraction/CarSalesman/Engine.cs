using System;
using System.Collections.Generic;
using System.Text;

namespace CarsSalesman
{
    public class Engine
    {
        private const string offset = "  ";

        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public string Model { get => this.model; set => this.model = value; }
        public int Power { get => this.power; set => this.power = value; }
        public int Displacement { get => this.displacement; set => this.displacement = value; }
        public string Efficiency { get => this.efficiency; set => this.efficiency = value; }

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = -1;
            this.Efficiency = "n/a";
        }

        public Engine(string model, int power, int displacement)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = "n/a";
        }

        public Engine(string model, int power, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = -1;
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }



        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{0}{1}:\n", offset, this.Model);
            stringBuilder.AppendFormat("{0}{0}Power: {1}\n", offset, this.Power);
            stringBuilder.AppendFormat("{0}{0}Displacement: {1}\n", offset, this.Displacement == -1 ? "n/a" : this.Displacement.ToString());
            stringBuilder.AppendFormat("{0}{0}Efficiency: {1}\n", offset, this.Efficiency);

            return stringBuilder.ToString();
        }
    }
}
