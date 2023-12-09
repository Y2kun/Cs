using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace animals {
    public class Marmot : Animal {
        public double armLenght;

        public Marmot(string? _name, double _weight, double _armLenght) : base(_name, _weight) {
            armLenght = _armLenght;
        }

        public override void cry() {
            Console.WriteLine("Whistle! - Whistle!");
        }

        public override string ToString() {
            return $"{base.ToString()}Arm Lenght: {armLenght}\n";
        }
    }
}