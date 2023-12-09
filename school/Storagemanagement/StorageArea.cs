using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storagemanagement {
    public class StorageArea {
        public double area;
        public long rent_duration;
        public double price;
        public Client? client;

        public StorageArea(double _area, long _rent_duration, string? client_name, double area_cost) {
            area = _area;
            rent_duration = _rent_duration;
            price = area_cost * area * rent_duration;
            client = new Client(client_name);
        }
    }
}