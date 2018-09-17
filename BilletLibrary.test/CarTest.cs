using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BilletLibrary.test
{
    [TestClass]
    public class CarTest
    {
        /// <summary>
        /// Tester metoderne i Car klassen
        /// </summary>
        [TestMethod]
        public void CarPriceTest()
        {
            Car car = new Car();

            decimal price = car.price();

            Assert.AreEqual(240, price);
        }

        [TestMethod]
        public void CarVehicleTest()
        {
            Car car = new Car();

            string vehicle = car.vehicle();

            Assert.AreEqual("Car", vehicle);
        }
    }
}
