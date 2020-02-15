using System;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Data;

namespace Portfolio.Services
{
    public class WeatherService : BaseService
    {
        public Task<Weather> GetWeatherAsync()
        {
            return Task.FromResult(_db.Weather.Where(x => x.Date == DateTime.Today).FirstOrDefault());
        }
    }
}
