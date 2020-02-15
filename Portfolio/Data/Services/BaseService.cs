using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Data.Contexts;

namespace Portfolio.Services
{
    public class BaseService
    {
        private ApplicationDbContext internalDb;
        public ApplicationDbContext _db
        {
            get
            {
                if (internalDb != null) return internalDb;
                try
                {
                    internalDb = new ApplicationDbContext();
                    internalDb.Database.CanConnect();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return internalDb;
            }
        }
    }
}
