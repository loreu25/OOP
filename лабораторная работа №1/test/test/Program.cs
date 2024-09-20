using System;
using System.Runtime.Intrinsics.Arm;

namespace test
{
    class Player {
        public string firstName;
        public string lastName;
        public int age;
        public string country;
        public string team;

        public Player(string firstName, string lastName, int age, string country, string team) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.country = country;
            this.team = team; 
        }
        public void Output(){
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Country: {country}");
            Console.WriteLine($"Team: {team}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Cristiano", "Ronaldo", 39, "Portugal", "Alnassr");

            player.Output();
        }
    }
}
