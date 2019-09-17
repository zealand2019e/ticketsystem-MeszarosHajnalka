using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicketLibrary;

namespace TicketSystemTest
{
    [TestClass]
    public class CarTestClass
    {
        Car car = new Car("ABC-234", new DateTime(2019, 11, 11));

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
        /// <summary>
        /// Testing if the licenseplate is more than 7 characters, then is it throwing an exception
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LicenseplateExceptionTest()
        {
            Car car = new Car("ABC-28888", new DateTime(2019, 11, 11));
        }
    }
}
