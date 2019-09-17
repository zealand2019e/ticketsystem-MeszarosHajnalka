using System;

namespace TicketLibrary
{
    public class MC:Vehicle
    {
        public MC(string licensePlate, DateTime date, bool brobizz) : base(licensePlate, date, brobizz)
        {
        }

        /// <summary>
        /// Method, which returns the price of the vehicle
        /// </summary>
        /// <returns>125</returns>
        public override decimal Price()
        {
            return calculatePrice(125);
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
