

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
        private decimal salary;
        private decimal increaseSalary;

      

        public Person(string firstName, string lastName, int age,decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
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
            private set => this.age = value;
        }
        public decimal Salary
        {
            get => this.salary;
            private set => this.salary = value;
        }
        

        public void IncreaseSalary(decimal precentage)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * precentage / 100;
            }
            else
            {
                this.Salary += this.Salary * precentage / 200;
            }
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:f2} leva.";
        }
    }

    
}
