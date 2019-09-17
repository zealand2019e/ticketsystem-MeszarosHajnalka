using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketLibrary;

namespace TicketSystemTest
{
    [TestClass]
    public class CarTestClass
    {
        Car car = new Car();

        /// <summary>
        /// Testing the Price method, if it returns the value that we expected.
        /// </summary>
        [TestMethod]
        public void PriceTestMethod()
        {
            decimal price = car.Price();
            Assert.AreEqual(240, price);
        }
        /// <summary>
        /// Testing the VehicleType method, if it returns the value that we expected.
        /// </summary>
        [TestMethod]
        public void VehicleTypeTestMethod()
        {
            string vehicle = car.VehicleType();
            Assert.AreEqual("Car", vehicle);
        }
    }
}
