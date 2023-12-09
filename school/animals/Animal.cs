using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace animals {
    public class Animal {
        public string? name;
        public double weight;
        
        public Animal(string? _name, double _weight) {
            name = _name;
            weight = _weight;
        }

        public virtual void cry() {
            Console.WriteLine("I am an Animal!");
        }

        public override string ToString() {
            return $"Name: {name}\nWeight: {weight}\n";
        }
    }
}