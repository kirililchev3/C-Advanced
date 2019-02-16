using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                if (value.Length < 1)
                {
                    throw new ArgumentException
                        ("Name is too short! It should be at least one letter.");
                }
                if (value.Length >= 100)
                {
                    throw new ArgumentException
                        ("Name is too long! The maximum size is 100 letters.");
                }
                this.name = value;
            }
        }
        public double Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1 || value >= 100)
                {
                    throw new ArgumentException
                        ("Invalid input! The age should be in range [1...100].");
                }
                this.age = (int)value;
            }
        }

        public string GetIformation()
        {
            var result = new StringBuilder();

            result.Append($"{this.Name} {this.Age}");
            return result.ToString();
        }

       



    }
}
