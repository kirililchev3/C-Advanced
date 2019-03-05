using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var team = new Team("Manchester United All Stars");

            team.AddPlayer(new Person("David", "Beckham", 45, 1000));
            team.AddPlayer(new Person("David", "DeGea", 25, 5000));
            team.AddPlayer(new Person("Dimitar", "Berbatov", 41, 3000));
            team.AddPlayer(new Person("Cristiano", "Ronaldo", 35, 10000));

            var firtsTeam = team.FirstTeam;
            var reserveTeam = team.ReserveTeam;

            Console.WriteLine(firtsTeam);
            Console.WriteLine(firtsTeam.Count);
            Console.WriteLine(reserveTeam);
            Console.WriteLine(reserveTeam.Count);

        }
    }
}
