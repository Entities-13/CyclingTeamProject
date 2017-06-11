using Cycling.Models.MSSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cycling.Data.Common.Repositories
{
    public class EfRepository : Repository<Cyclist>
    {
        public EfRepository(DbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
