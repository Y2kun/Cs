using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace snailRace {
    public class Race {
        public string? raceName;
        public List<Snail> racingSnails;
        public int numberOfSnails;
        public double length;
        
        public Race(string? name, double _length) {
            raceName = name;
            length = _length;
        }

        public void AddSnail(Snail snail) {
            racingSnails.Add(snail);
            numberOfSnails = racingSnails.Count();
        }

        public void RemoveSnail(string snail) {
            foreach (Snail index in racingSnails) {
                if(index.name == snail) {
                    index.Remove(snail);
                    numberOfSnails = racingSnails.Count();
                    Console.WriteLine("Snail not Found");
                } else {
            }

                Console.WriteLine("Snail not Found");
            }
        }

        public string Info() {
            string snailsString;
            foreach (Snail index in racingSnails) {
                snailsString += index.name;
            }
            return "Race Name: " + raceName + "\nNumber of Snails: " + numberOfSnails + "\nRace length: " + length + "\nSnails: " + snailsString;
        }
    }
}