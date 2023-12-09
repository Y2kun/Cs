using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storagemanagement {
    public class Building {
        public double total_area;
        public double area_cost;
        public List<StorageArea> storage_Areas = new List<StorageArea>();

        public Building(double _total_area, double _area_cost) {
            total_area = _total_area;
            area_cost = _area_cost;
        }

        public bool addStorageArea(double area, long duration, string? client_name) {
            if (freeArea()) {
                storage_Areas.Add(new StorageArea(area, duration, client_name, area_cost));
                return true;
            } else {
                return false;
            }
        }

        public bool freeArea() {
            double total_used_area = 0;
            foreach (StorageArea storagearea in storage_Areas) {
               total_used_area += storagearea.area;
            }

            if (total_used_area <= total_area) {
                return true;
            } else {
                return false;
            }
        }

        public double calculatePrice(string? name) {
            double total_price_for_client = 0;
            foreach (StorageArea storagearea in storage_Areas) {
                if (storagearea.client.name == name) {
                    total_price_for_client += storagearea.price;
                }
            }
            return total_price_for_client;
        }
    }
}