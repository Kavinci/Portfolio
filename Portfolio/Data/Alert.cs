using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Data
{
    public class Alert
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Time { get; set; }
        public DateTime Expires { get; set; }
        public string Description { get; set; }
        public string URI { get; set; }
    }
}
