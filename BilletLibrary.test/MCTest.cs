using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary.test
{
    [TestClass]
    public class MCTest
    {
        /// <summary>
        /// Tester metoderne i MC klassen
        /// </summary>
        [TestMethod]
        public void CarPriceTest()
        {
            MC mc = new MC();

            decimal price = mc.price();

            Assert.AreEqual(125, price);
        }

        [TestMethod]
        public void CarVehicleTest()
        {
            MC mc = new MC();

            string vehicle = mc.vehicle();

            Assert.AreEqual("MC", vehicle);
        }

    }
}
