using System;

namespace animals {
    internal class Program {
        static void Main(string[] args) {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("U.A", 0.5));
            animals.Add(new Cat("Pancake", 8, 10.2));
            animals.Add(new Cow("Chocolate", 100, 100));
            animals.Add(new Marmot("Morm", 3, 0.8));

            foreach (Animal animal in animals) {
                animal.cry();
                Console.WriteLine($"{animal.ToString()}");
            }
        }
    }
}
