using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace UnitTestProject
{
    [TestClass]
    public class avg_test
    {
        [TestMethod]
        public void TestAvgYear()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle { Year = 2010 },
                new Vehicle { Year = 2020 },
                new Vehicle { Year = 2000 }
            };

            var manager = new FleetManager();
            foreach (var v in vehicles)
                manager.AddVehicle(v);

            double average = manager.CalculateAverageYear();

            Assert.AreEqual(2010, average);
        }
        [TestMethod]
        public void TestAvgYear_EmptyList_ReturnsZero()
        {
            var manager = new FleetManager();
            double avg = manager.CalculateAverageYear();
            Assert.AreEqual(0, avg); 
        }

        [TestMethod]
        public void TestAvgYear_AllSameYear()
        {
            var manager = new FleetManager();
            manager.AddVehicle(new Vehicle { Year = 2015 });
            manager.AddVehicle(new Vehicle { Year = 2015 });
            manager.AddVehicle(new Vehicle { Year = 2015 });

            double avg = manager.CalculateAverageYear();
            Assert.AreEqual(2015, avg);
        }
    }
}
