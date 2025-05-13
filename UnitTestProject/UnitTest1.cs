using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SortByYearDescending_ReturnsList()
        {
            var manager = new FleetManager();
            manager.AddVehicle(new Vehicle { ID = 1, Year = 2020 });
            manager.AddVehicle(new Vehicle { ID = 2, Year = 2018 });

            var result = manager.SortByYearDescending();

            Assert.IsNotNull(result); 
        }

        [TestMethod]
        public void SortByYearDescending_KeepsAllVehicles()
        {
            var manager = new FleetManager();
            manager.AddVehicle(new Vehicle { ID = 1, Year = 2020 });
            manager.AddVehicle(new Vehicle { ID = 2, Year = 2018 });
            manager.AddVehicle(new Vehicle { ID = 3, Year = 2019 });

            var result = manager.SortByYearDescending();

            Assert.AreEqual(3, result.Count); // לא נעלמו רכבים
        }

        [TestMethod]
        public void SortByYearDescending_IsSortedCorrectly()
        {
            var manager = new FleetManager();
            manager.AddVehicle(new Vehicle { ID = 1, Year = 2018 });
            manager.AddVehicle(new Vehicle { ID = 2, Year = 2022 });
            manager.AddVehicle(new Vehicle { ID = 3, Year = 2020 });

            var result = manager.SortByYearDescending();

            for (int i = 0; i < result.Count - 1; i++)
            {
                Assert.IsTrue(result[i].Year >= result[i + 1].Year, "הרשימה לא ממוינת נכון");
            }
        }
    }
}

