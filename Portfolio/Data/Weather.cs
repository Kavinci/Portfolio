using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Data
{
    public class Weather
    {
        public Guid Id { get; set; }
        public string Summary { get; set; }
        public string Icon { get; set; }
        public DateTime Date { get; set; }
        public Forecast Forecast { get; set; }
        public List<Alert> Alerts { get; set; }
    }
}
