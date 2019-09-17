using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketLibrary;


namespace TicketSystemTest
{
    [TestClass]
   public class MCTestClass
    {
        MC mc = new MC("ABC-123", new DateTime(2019,11,11),false);
        /// <summary>
        /// Testing the Price method, if it returns the value that we expected.
        /// </summary>
        [TestMethod]
        public void PriceTestMethod()
        {
            decimal price = mc.Price();
            Assert.AreEqual(125, price);
        }
        /// <summary>
        /// Testing the Vehicle method, if it returns the value that we expected.
        /// </summary>
        [TestMethod]
        public void VehicleTypeTestMethod()
        {
            string vehicle = mc.Vehicle();
            Assert.AreEqual("MC",vehicle);

        }
    }
}
