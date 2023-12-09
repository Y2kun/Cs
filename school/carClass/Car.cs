using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carClass {
    internal class Car {
        public string color = "White";
        public int weight = 0;
        public int ps = 0;
        public double v = 0;
        Radio radio;

        public void honk() {
            Console.WriteLine("Please input for how long you want to honk between 1-5");
            int parameter = Convert.ToInt32(Console.ReadLine());
            if (parameter < 1) {parameter = 1;}
            if (parameter > 5) {parameter = 5;}
            for(int i = 0; i < parameter; i++) {
                //Console.Beep();
                Console.WriteLine("honk, honk #" + (i+1));
            }
        }

        public void accelerate(){
            Console.WriteLine("Please input how much you want to accelerate between 1-10 when over 100 ps 1-5");
            int parameter = Convert.ToInt32(Console.ReadLine());
            if (parameter < 1) {parameter = 1;}
            if (parameter > 5 && ps > 100) {parameter = 5;}
            else if (parameter > 10) {parameter = 10;}
            v += 5.7 * parameter;
            if (v > 200) {
                Console.WriteLine("Terminal Velocity reached!");
                v = 200;
            } else {
                Console.WriteLine("The Speed of the Car is " + v);
            }
        }

        public void breaking() {
            Console.WriteLine("Please input how much you want to break 1-25");
            int parameter = Convert.ToInt32(Console.ReadLine());
            if (parameter < 1) {parameter = 1;}
            if (parameter > 25) {parameter = 25;}
            v -= 3.4 * parameter;
            if (v < 0) {
                Console.WriteLine("The Car is standing still!");
                v = 0;
            } else {
                Console.WriteLine("The Speed of the Car is " + v);
            }
        }
    }
}