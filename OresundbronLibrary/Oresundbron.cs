using System;
using TicketLibrary;

namespace OresundbronLibrary
{
    public class Oresundbron
    {

        public static double OresundPrice(object obj)
        {
            double x;

            if (obj.GetType() == typeof(Car) || obj.GetType() == typeof(MC))
            {
                if (obj.GetType() == typeof(Car))
                {
                  return x = CarPriceChange(obj as Car);
                }
                if (obj.GetType() == typeof(MC))
                {
                    return x = MCPriceChange(obj as MC);
                    
                }
            }

            throw new Exception("Object type has to be 'Car' or 'MC'.");
          
        }

        private static double MCPriceChange(MC mc)
        {
            double x;
            if (mc.Brobizz == true)
            {
              return x = 73;
            }

            return x = 210;
            
        }

        private static double CarPriceChange(Car car)
        {
            double x;
            if (car.Brobizz == true)
            {
                return x = 161;
            }

            x = 410;
            return x;
        }


        public static string VehicleType(object obj)
        {
            if (obj.GetType() == typeof(Car) || obj.GetType() == typeof(MC))
            {
                string s;

                if (obj.GetType() == typeof(Car))
                {
                    return s = "Oresund car";
                }
                if (obj.GetType() == typeof(MC))
                {
                    return s = "Oresund MC";
                }
            }

            throw new Exception("Object type has to be 'Car' or 'MC'.");
        }
    }
}
