using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Data
{
    public class Portland
    {
        public static double Latitude = 45.5083;
        public static double Longitude = -122.666;
        public static DateTime CurrentTime;

        public static double UTCOffset = -8;
        private static double PST = -8;
        private static double PDT = -7;

        public static void UpdateTime()
        {
            CurrentTime = DateTime.UtcNow.AddHours(UTCOffset);
            if (CurrentTime.IsDaylightSavingTime())
            {
                UTCOffset = PDT;
                CurrentTime = DateTime.UtcNow.AddHours(UTCOffset);
            }
            else
            {
                UTCOffset = PST;
                CurrentTime = DateTime.UtcNow.AddHours(UTCOffset);
            }
        }

        public static void UpdateEnvironment() { }
        public static void UpdateAstronomy() { }
        public static void UpdateWeather() { }
    }
}
