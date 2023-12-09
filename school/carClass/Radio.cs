using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carClass {
    internal class Radio{
        private Modes Mode;
        bool status = false;
        int currentMode = Mode.Radio;
        double frequency = 99;
        double volume = 5;

        public void StatusChange() {
            if(status == false) {Console.WriteLine("Do you want to turn the Radio on? (Y|N)");}
            else if(status == ture) {Console.WriteLine("Do you want to turn the Radio off? (Y|N)");}
            if(Console.Read() == "Y") {status = true;}
            else if(Console.Read() == "N") {status = false;}
        }

        
    }
}