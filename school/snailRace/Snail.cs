using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace snailRace {
    public class Snail {
        public string? name;
        public string? race;
        public double maxSpeed;
        public double crossed = 0;

        public Snail(string? _name, string? _race, double _maxSpeed) {
            name = _name;
            race = _race;
            maxSpeed = _maxSpeed;
        }

        public void Crawl() {
            double crawlAmount = new Random().NextDouble() * maxSpeed;
            crossed += crawlAmount;
            Console.WriteLine($"The Snail Crawled #{crawlAmount}, the Snail has crosse in total #{crossed}");
        }

        public string Info() {
            return "Name: " + name + "\nRace: " + race + "\nmax Speed: " + maxSpeed + "\nDistance crossed: " + crossed;
        }
    }
}
