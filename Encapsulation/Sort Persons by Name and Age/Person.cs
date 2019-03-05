

namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName
        {
            get => this.firstName;
            private set => this.firstName = value;
        }
        public string LastName
        {
            get => this.lastName;
            private set => this.lastName = value;
        }
        public int Age
        {
            get => this.age;
            set => this.age = value;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }

    
}
