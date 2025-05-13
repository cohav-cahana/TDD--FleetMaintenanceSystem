using System;
using System.Collections.Generic;
using System.IO;
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
        public List<Vehicle> GetAllVehicles()
        {
            return vehicles;
        }
        public void SaveToFile(string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (var v in vehicles)
                {
                    writer.WriteLine($"{v.ID},{v.Model},{v.Manufacturer},{v.Year},{v.Type},{v.MaintenanceStatus}");
                }
            }
        }

        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath)) return;

            vehicles.Clear();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                var v = new Vehicle
                {
                    ID = int.Parse(parts[0]),
                    Model = parts[1],
                    Manufacturer = parts[2],
                    Year = int.Parse(parts[3]),
                    Type = parts[4],
                    MaintenanceStatus = parts[5]
                };
                vehicles.Add(v);
            }
        }

        /* public List<Vehicle> SortByYearDescending()
         {
             var sorted = vehicles.ToList(); 

             var stopwatch = System.Diagnostics.Stopwatch.StartNew();

             for (int i = 0; i < sorted.Count - 1; i++)
             {
                 for (int j = 0; j < sorted.Count - i - 1; j++)
                 {
                     if (sorted[j].Year < sorted[j + 1].Year)
                     {
                         var temp = sorted[j];
                         sorted[j] = sorted[j + 1];
                         sorted[j + 1] = temp;
                     }
                 }
             }

             stopwatch.Stop();
             Console.WriteLine($"Sorting took {stopwatch.ElapsedMilliseconds} ms");

             return sorted;
         }*/

        public List<Vehicle> SortByYearDescending()
        {
            var sorted = vehicles.ToList();

            var stopwatch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < sorted.Count - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < sorted.Count; j++)
                {
                    if (sorted[j].Year > sorted[maxIndex].Year)
                    {
                        maxIndex = j;
                    }
                }

                if (maxIndex != i)
                {
                    var temp = sorted[i];
                    sorted[i] = sorted[maxIndex];
                    sorted[maxIndex] = temp;
                }
            }

                stopwatch.Stop();
            Console.WriteLine($"Sorting took {stopwatch.ElapsedMilliseconds} ms");

            return sorted;
            
        }
    }
}
    

