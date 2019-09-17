using System;

namespace TicketLibrary
{
    public class Vehicle
    {
        private string licensePlate;
        private DateTime date;
        private bool brobizz;

        public Vehicle(string licensePlate, DateTime date, bool brobizz)
        {
            if (licensePlate.Length > 7)
            {
               throw new ArgumentException("Licenseplate cannot be more then 7 characters long...");
            }
            this.licensePlate = licensePlate;
            this.date = date;
            this.brobizz = brobizz;
        }

        public string LicensePlate { get => licensePlate; }
        public DateTime Date { get => date; }
        /// <summary>
        /// Method, which returns a default value, and it will be overrided
        /// </summary>
        /// <returns>100</returns>
        public virtual decimal Price()
        {          
            return calculatePrice(100);
        }
        /// <summary>
        /// Method, which is checking if the discount needs to be applied
        /// </summary>
        /// <param name="price"></param>
        /// <returns>the price with or without the discount</returns>
        protected decimal calculatePrice(decimal price)
        {
            decimal x = price;

            if (brobizz)
            {
                x = x - x / 100 * 5;
                return x;
            }

            return x;

        }
    }
}
