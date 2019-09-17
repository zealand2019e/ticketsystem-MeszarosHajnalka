using System;

namespace TicketLibrary
{
    public class Car:Vehicle
    {
        public Car(string licensePlate, DateTime date, bool brobizz) : base(licensePlate, date, brobizz)
        {
        }

        /// <summary>
        /// Method which returns the price of the car
        /// </summary>
        /// <returns>240</returns>
        public override decimal Price()
        {
            return calculatePrice(240);
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
