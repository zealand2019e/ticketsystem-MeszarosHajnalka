using System;

namespace TicketLibrary
{
    public class Vehicle
    {
        private string licensePlate;
        private DateTime date;

        public Vehicle(string licensePlate, DateTime date)
        {
            if (licensePlate.Length > 7)
            {
               throw new ArgumentException("Licenseplate cannot be more then 7 characters long...");
            }
            this.licensePlate = licensePlate;
            this.date = date;
        }

        public string LicensePlate { get => licensePlate; }
        public DateTime Date { get => date; }
        /// <summary>
        /// Method, which returns a default value, and it will be overrided
        /// </summary>
        /// <returns>100</returns>
        public virtual decimal Price()
        {
            return 100;
        }
    }
}
