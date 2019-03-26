using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) 
            : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
        }

        public override string FirstName
        {
            get => base.FirstName;
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }
                base.FirstName = value;
            }
        }
        public override string LastName
        {
            get => base.LastName;

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }
                base.LastName = value;
            }

        }

        public string FacultyNumber
        {
            get => this.facultyNumber;

            set
            {
                if (value.Length < 5 || value.Length > 10 || !IsValidFacultyNumber(value))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        private bool IsValidFacultyNumber(string value)
        {
            bool isValidFacultyNumber = true;
            foreach (var ch in value)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    isValidFacultyNumber = false;
                }
            }

            return isValidFacultyNumber;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("First Name: ").Append(this.FirstName)
                .Append(Environment.NewLine)
                .Append("Last Name: ").Append(this.LastName)
                .Append(Environment.NewLine)
                .Append("Faculty number: ").Append(this.FacultyNumber);

            return stringBuilder.ToString();

        }
    }
}
