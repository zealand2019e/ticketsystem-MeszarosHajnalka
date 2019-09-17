using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicketLibrary;

namespace TicketSystemTest
{
    [TestClass]
   public class VehicleFunctionalityTest
    {
        /// <summary>
        /// Testing if the licenseplate is more than 7 characters, then is it throwing an exception
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LicenseplateExceptionTest()
        {
            Car car = new Car("ABC-28888", new DateTime(2019, 11, 11), false);
        }
        /// <summary>
        /// Testing if the 5% brobizz discount was applied
        /// </summary>
        [TestMethod]
        public void BrobizzDiscountTest()
        {
            Car car = new Car("ABC-288", new DateTime(2019, 11, 11), true);
            MC mc = new MC("ABC-123", new DateTime(2019, 11, 11), true);

            decimal brobizzCarDiscount = car.Price();
            decimal brobizzMCDiscount = mc.Price();

            Assert.AreEqual(228, brobizzCarDiscount);
            Assert.AreEqual(Convert.ToDecimal(118.75) , brobizzMCDiscount);
        }
    }
}
