using System;

namespace Portfolio.Data
{
    public class Forecast
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Summary { get; set; }
        public string Icon { get; set; }
        public DateTime Sunrise { get; set; }
        public DateTime Sunset { get; set; }
        public double MoonPhase { get; set; }
        public double PrecipitationIntensity { get; set; }
        public double PrecipitationIntensityMax { get; set; }
        public DateTime PrecipitationIntensityMaxTime { get; set; }
        public double PrecipitationProbability { get; set; }
        public string PrecipitationType { get; set; }
        public double TemperatureHigh { get; set; }
        public DateTime TemperatureHighTime { get; set; }
        public double TemperatureLow { get; set; }
        public DateTime TemperatureLowTime { get; set; }
        public double ApparentTemperatureHigh { get; set; }
        public DateTime ApparentTemperatureHighTime { get; set; }
        public double ApparentTemperatureLow { get; set; }
        public DateTime ApparentTemperatureLowTime { get; set; }
        public double DewPoint { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
        public double WindSpeed { get; set; }
        public double WindGust { get; set; }
        public DateTime WindGustTime { get; set; }
        public double WindBearing { get; set; }
        public double CloudCover { get; set; }
        public int UVIndex { get; set; }
        public DateTime UVIndexTime { get; set; }
        public int Visibility { get; set; }
        public double Ozone { get; set; }
        public double TemperatureMin { get; set; }
        public DateTime TemperatureMinTime { get; set; }
        public double TemperatureMax { get; set; }
        public DateTime TemperatureMaxTime { get; set; }
        public double ApparentTemperatureMin { get; set; }
        public DateTime ApparentTemperatureMinTime { get; set; }
        public double ApparentTemperatureMax { get; set; }
        public DateTime ApparentTemperatureMaxTime { get; set; }
    }
}
