using System;

namespace snailRace {
    internal class Programm {  
        static void Main(string[] args) {
            Race race;
            createRace(race);
            createSnail(race);
        }

        static void createSnail(Race race) {
            string? name;
            string? race;
            double maxSpeed;

            Console.WriteLine("Input the Name of the Snail:");
            name = Console.ReadLine();
            Console.WriteLine("Input the Race of the Snail:");
            race = Console.ReadLine();
            Console.WriteLine("Input the Max Speed of the Snail:");
            if (!double.TryParse(Console.ReadLine(), out maxSpeed)) {Console.WriteLine("Error Input Invalid");}

            race.AddSnail(new Snail(name, race, maxSpeed));
        }
        
        static void createRace(Race race) {
            string? raceName;
            double length;

            Console.WriteLine("Input the Name of the Race:");
            raceName = Console.ReadLine();
            Console.WriteLine("Input the Lenght of the Race:");
            if (!double.TryParse(Console.ReadLine(), out length)) {Console.WriteLine("Error Input Invalid");}

            race = new Race(raceName, length);
        }
    }
}


// foreach (Snail index in Snails) {
//     Console.WriteLine(index.Crawl());
// }

// foreach (Snail index in Snails) {
//     Console.WriteLine(index.Info());
// }

// Race.Info();