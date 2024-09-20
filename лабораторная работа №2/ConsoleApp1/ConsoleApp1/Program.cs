using System;

namespace ConsoleApp1
{
    struct Stats
    {
        public int goals;
        public int assist;

        public Stats(int goals, int assist)
        {
            this.goals = goals;
            this.assist = assist;
        }

        public Stats WithStat(int? newGoals, int? newAssists)
        {
            return new Stats(
                newGoals ?? this.goals, 
                newAssists ?? this.assist
            );
        }

        public void outputStats()
        {
            Console.WriteLine($"Goals: {goals}, Assists: {assist}");
        }

    }
    class Player
    {
        private string firstName;
        public string lastName;
        public int age;
        public string country;
        public string team;

        public string FirstName {set{firstName = value;} get{return firstName;}}

        public Player(string firstName, string lastName, int age, string country, string team)
        {
            FirstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.country = country;
            this.team = team;
        }

        public Player WithTeam(string newFirstName, string newLastName, int? newAge, string newCountry, string newTeam)
        {
            return new Player(
                newFirstName ?? this.firstName,
                newLastName ?? this.lastName,
                newAge ?? this.age,
                newCountry ?? this.country,
                newTeam ?? this.team
               );
        }
        public void outputPlayerInfo() 
        {
            Console.WriteLine($"Name: {firstName} {lastName}, Age: {age}, Country: {country}, Team: {team}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Cristiano", "Ronaldo", 39, "Portugal", "Alnassr");
            player.outputPlayerInfo();

            Player newPlayer = player.WithTeam(null, null, null, null, "Real Madrid");
            newPlayer.outputPlayerInfo();

            Stats stats = new Stats(901, 253);
            stats.outputStats();

            Stats newStats = stats.WithStat(902, null);
            newStats.outputStats();

            Player pp = new Player("Cristfdfdiano", "Ronalfdfddo", 339, "Portfdfdugal", "Alnassrfdfd");
        }
    }
}