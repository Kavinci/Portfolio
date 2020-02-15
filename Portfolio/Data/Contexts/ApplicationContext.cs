using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data;

namespace Portfolio.Data.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base() { }
        public ApplicationContext(DbContextOptions options): base(options){}
        public DbSet<Weather> Weather { get; set; }
        public DbSet<Astronomy> Astronomy { get; set; }
        public DbSet<Alert> Alerts { get; set; }
        public DbSet<Forecast> Forecasts { get; set; }
    }
}
