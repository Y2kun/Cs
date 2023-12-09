using System;

//unfinished

namespace carClass {
    public class Programm {  
        public static void Main(string[] args) {
            Car car = new Car();
            Radio player = new Radio();
            car.color = "black";
            car.weight = 500;
            car.ps = 200;
            car.accelerate();
            car.ps = 100;
            car.accelerate();
            car.breaking();
            car.honk();
        }
    }
}