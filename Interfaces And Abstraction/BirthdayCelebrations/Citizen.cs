using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IIdentifiable, IBirthable, IName
    {
        
        private int age;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.age = age;
            this.Id = id;
            this.Birthdate = DateTime.ParseExact(birthdate, "dd/mm/yyyy", null);
            this.Name = name;
        }

        public string Id { get; private set; }

        public DateTime Birthdate { get; private set; }

        public string Name { get; private set; }
    }
}
