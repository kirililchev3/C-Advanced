using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Rebel : IBuyer,IAge
    {
        private string group;

        public Rebel(string name, int age, string group)
        {
            this.group = group;
            this.Age = age;
            this.Name = name;
        }

        public int Age { get; private set; }

        public string Name { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
