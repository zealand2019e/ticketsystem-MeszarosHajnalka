using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketLibrary;
using StoreBaeltTicketLibrary;

namespace TicketSystemTest
{
    [TestClass]
    public class StoreBaeltTicketTestClass
    {
        [TestMethod]

        public void WeekendTest()
        {
            Car car = new Car("plate",new DateTime(2019,09,21),true);
            Car car2 = new Car("plate", new DateTime(2019,09,19), false);
            Car car3 = new Car("plate", new DateTime(2019,09,22), false);

            Assert.AreEqual(192,SatSunDiscount.WeekendDiscountCalculation(car));
            Assert.AreEqual(240, SatSunDiscount.WeekendDiscountCalculation(car2));
            Assert.AreEqual(192, SatSunDiscount.WeekendDiscountCalculation(car3));
        }
    }
}
