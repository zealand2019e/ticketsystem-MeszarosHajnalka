using System;
using TicketLibrary;

namespace StoreBaeltTicketLibrary
{
    public class SatSunDiscount
    {
       static public double WeekendDiscountCalculation(Car car)
        {
            double x;

            if (car.Date.DayOfWeek == DayOfWeek.Sunday || car.Date.DayOfWeek == DayOfWeek.Saturday)
            {
                car.Brobizz = false;
                x = Convert.ToDouble(car.Price());
                x = x * 0.8;

                return x;
            }

            return Convert.ToDouble(car.Price());
        }
    }
}
