using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace animals {
    public class Cat : Animal {
        public double whiskersLenght;

        public Cat(string? _name, double _weight, double _whiskersLenght) : base(_name, _weight) {
            whiskersLenght = _whiskersLenght;
        }

        public override void cry() {
            Console.WriteLine("Purrr - Meow - Purrr");
        }

        public override string ToString() {
            return $"{base.ToString()}Whiskers Length: {whiskersLenght}\n";
        }
    }
}