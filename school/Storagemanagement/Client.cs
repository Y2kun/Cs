using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storagemanagement {
    public class Client {
        public string? name;
        public int pin;

        public Client(string? _name) {
            name = _name;

            for (int i = 0; i < 3; i++) {
                pin = Convert.ToInt32(pin.ToString() + new Random().Next(1, 9).ToString());
            }
        }
    }
}