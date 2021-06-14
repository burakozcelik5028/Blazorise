using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Data
{
    public class WeatherForecastService
    {
        private readonly ApplicationDBConnect _context;

        public WeatherForecastService(ApplicationDBConnect context)
        {
            _context = context;
        }

        public Task<List<WeatherForecast>> GetForecastAsync()
        {
            return Task.FromResult(_context.Forecasts.ToList());
        }

        public async Task<string> UpdateForeCast(WeatherForecast forecast)
        {
            _context.Update(forecast);
            await _context.SaveChangesAsync();
            return "Success";
        }
        public async Task<string> SaveForeCast(WeatherForecast forecast)
        {
            _context.Add(forecast);
            await _context.SaveChangesAsync();
            return "Success";
        }
        public async Task<string> DeleteForeCast(int id)
        {
            var forecast = await _context.Forecasts.FindAsync(id);
            _context.Forecasts.Remove(forecast);
            await _context.SaveChangesAsync();
            return "Success";
        }
    }
}
