using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.Data
{
    public class ApplicationDBConnect : DbContext
    {
        public ApplicationDBConnect(DbContextOptions<ApplicationDBConnect> options) : base(options) { }

        public DbSet<WeatherForecast> Forecasts { get; set; }

    }
}
