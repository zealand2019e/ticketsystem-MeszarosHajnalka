using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class Car
    {
        public string licensePlate;
        public DateTime date;

        /// <summary>
        /// Method which returns the price of the car
        /// </summary>
        /// <returns>240</returns>
        public decimal Price()
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
