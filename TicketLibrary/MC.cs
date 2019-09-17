using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
   public class MC:Vehicle
    {
        public MC(string licensePlate, DateTime date) : base(licensePlate, date)
        {
        }

        /// <summary>
        /// Method, which returns the price of the vehicle
        /// </summary>
        /// <returns>125</returns>
        public override decimal Price()
        {
            return 125;
        }
        /// <summary>
        /// Method, which returns the type of the vehicle
        /// </summary>
        /// <returns>MC</returns>
        public string Vehicle()
        {
            return "MC";
        }
    }
}
