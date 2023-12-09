using System;

namespace Storagemanagement {
    internal class Program {
        static void Main(string[] args) {
            List<Building> buildings = new List<Building>();
            buildings.Add(new Building(10000000, 2));
            foreach (Building building in buildings) {
                Console.WriteLine(building.addStorageArea(100, 5, "Y2kun"));
                Console.WriteLine(building.freeArea());
                Console.WriteLine(building.calculatePrice("Y2kun"));
            }
        }
    }
}