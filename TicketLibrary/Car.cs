using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class Car:Vehicle
    {
       

        public Car(string licensePlate, DateTime date) : base(licensePlate, date)
        {
        }

        /// <summary>
        /// Method which returns the price of the car
        /// </summary>
        /// <returns>240</returns>
        public override decimal Price()
        {
            return 240;
        }
        /// <summary>
        /// Method which returns the type of the vehicle
        /// </summary>
        /// <returns>Car</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
