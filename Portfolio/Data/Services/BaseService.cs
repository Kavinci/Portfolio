using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Data.Contexts;

namespace Portfolio.Services
{
    public class BaseService
    {
        private ApplicationContext internalDb;
        public ApplicationContext _db
        {
            get
            {
                if (internalDb != null) return internalDb;
                try
                {
                    internalDb = new ApplicationContext();
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
