using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Data;

namespace Portfolio.Services
{
    public class AstronomyService : BaseService
    {
        public Task<Astronomy> GetAstronomyAsync()
        {
            return Task.FromResult(_db.Astronomy.Where(x => x.Date == DateTime.Today).FirstOrDefault());
        }
    }
}
