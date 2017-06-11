using Cycling.Data.Common.Contracts;
using Cycling.Data.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycling.Data.Common
{
    public class EfUnitOfWork : IUnitOfWork, IDisposable
    {
        private DbContext dbContext;

        public EfUnitOfWork(DbContext dbcontext)
        {
            this.dbContext = dbcontext;
            this.CyclistsRepo = new EfRepository(this.dbContext);
        }

        public EfRepository CyclistsRepo { get; private set; }


        public void Commit()
        {
            this.dbContext.SaveChanges();
        }

        public void Dispose()
        {
            this.dbContext.Dispose();
        }
    }
}
