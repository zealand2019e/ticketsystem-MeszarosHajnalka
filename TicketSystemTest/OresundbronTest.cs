using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundbronLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using TicketLibrary;

namespace TicketSystemTest
{
    [TestClass]
    public class OresundbronTest
    {



        [TestMethod]
        public void OresundPriceTest()
        {
            Car car = new Car("ABC-234", new DateTime(2019, 11, 11), false);
            MC mc = new MC("ABC-123", new DateTime(2019, 11, 11), false);

            Car car1 = new Car("ABC-234", new DateTime(2019, 11, 11), true);
            MC mc1 = new MC("ABC-123", new DateTime(2019, 11, 11), true);

            double carOresundPriceNoBrobizz = Oresundbron.OresundPrice(car);
            double MCOresundPriceNoBrobizz = Oresundbron.OresundPrice(mc);

            double carOresundPriceBrobizz = Oresundbron.OresundPrice(car1);
            double MCOresundPriceBrobizz = Oresundbron.OresundPrice(mc1);

            Assert.AreEqual(410 , carOresundPriceNoBrobizz);
            Assert.AreEqual(210, MCOresundPriceNoBrobizz);

            Assert.AreEqual(161, carOresundPriceBrobizz);
            Assert.AreEqual(73, MCOresundPriceBrobizz);


        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void OresundPriceMethodExecptionTest()
        {

            Vehicle veh = new Vehicle("plate",DateTime.Now,false);
            Oresundbron.OresundPrice(veh);
        }

        [TestMethod]
        public void OresundVehicleType()
        {
            Car car = new Car("ABC-234", new DateTime(2019, 11, 11), false);
            MC mc = new MC("ABC-123", new DateTime(2019, 11, 11), false);

            string carType = Oresundbron.VehicleType(car);
            string mcType = Oresundbron.VehicleType(mc);

            Assert.AreEqual("Oresund car", carType);
            Assert.AreEqual("Oresund MC", mcType);

        }
    }
}
