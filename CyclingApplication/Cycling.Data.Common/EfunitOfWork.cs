using Cycling.Data.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycling.Data.Common
{
    public class EfunitOfWork : IUnitOfWork, IDisposable
    {
        private DbContext dbContext;

        public EfunitOfWork(DbContext dbcontext)
        {
            this.dbContext = dbcontext;
        }

        public void Commit()
        {
            this.dbContext.SaveChanges();
        }

        public void Dispose()
        {
        }
    }
}
