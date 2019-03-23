using System;
using System.Collections.Generic;
using System.Text;

namespace CarsSalesman
{
    public class Car
    {
        private const string offset = "  ";

        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public string Model { get => this.model; set => this.model = value; }
        public Engine Engine { get => this.engine; set => this.engine = value; }
        public int Weight { get => this.weight; set => this.weight = value; }
        public string Color { get => this.color; set => this.color = value; }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = -1;
            this.Color = "n/a";
        }

        public Car(string model, Engine engine, int weight)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = "n/a";
        }

        public Car(string model, Engine engine, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = -1;
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{0}:\n", this.Model);
            stringBuilder.Append(this.Engine.ToString());
            stringBuilder.AppendFormat("{0}Weight: {1}\n", offset, this.Weight == -1 ? "n/a" : this.Weight.ToString());
            stringBuilder.AppendFormat("{0}Color: {1}", offset, this.Color);

            return stringBuilder.ToString();
        }
    }
}
