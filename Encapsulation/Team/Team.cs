

namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.Name = name;

            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public IReadOnlyCollection<Person> FirstTeam
        { get => this.firstTeam.AsReadOnly(); }
        public IReadOnlyCollection<Person> ReserveTeam
        { get => this.reserveTeam.AsReadOnly(); }
        public string Name { get => this.name; set => this.name = value; }

        public void AddPlayer (Person player)
        {
            if (player == null)
            {
                throw new ArgumentNullException(nameof(player), "Player cannot be null.");
            }

            if (player.Age < 40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player);
            }
        }
    }
}
