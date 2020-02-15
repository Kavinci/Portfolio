using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Data
{
    public class Astronomy
    {
        public Guid Id { get; set; }
        public GeoLocation Location { get; set; }
        public DateTime Date { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Sunset { get; set; }
        public DateTime SolarNoon { get; set; }
        public TimeSpan DayLength { get; set; }
        public double SunAltitude { get; set; }
        public double SunDistance { get; set; }
        public double SunAzimuth { get; set; }
        public DateTime Moonrise { get; set; }
        public DateTime Moonset { get; set; }
        public double MoonAltitude { get; set; }
        public double MoonDistance { get; set; }
        public double MoonAzimuth { get; set; }
        public double MoonParallacticAngle { get; set; }
    }
}
