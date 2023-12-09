using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace animals {
    public class Cow : Animal{
        public double milkAmount;

        public Cow(string? _name, double _weight, double _milkAmount) : base(_name, _weight) {
            milkAmount = _milkAmount;
        }

        public override void cry() {
            Console.WriteLine("Moo! - Moo!");
        }

        public override string ToString() {
            return $"{base.ToString()}Milk Amount: {milkAmount}\n";
        }
    }
}