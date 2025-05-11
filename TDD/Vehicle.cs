using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Vehicle
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public string MaintenanceStatus { get; set; }
    }
    public class FleetManager
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }
        public double CalculateAverageYear()
        {
            if (vehicles.Count == 0)
                return 0;

            return vehicles.Average(v => v.Year);
        }


    }
}

