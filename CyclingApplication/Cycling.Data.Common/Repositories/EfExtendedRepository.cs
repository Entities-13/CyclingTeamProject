using Cycling.Data.Common.Contracts;
using Cycling.Models.MSSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cycling.Data.Common.Repositories
{
    public class EfExtendedRepository : EfRepository<Cyclist>, IEfExtendedRepository
    {
        public EfExtendedRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        public void RemoveByFirstAndLastName(string firstName, string lastName)
        {
            var cyclistsToRemove = base.DbSet.Where(x => x.FirstName.Contains(firstName)
                            && x.LastName.Contains(lastName)).ToList();

            foreach (var cyclist in cyclistsToRemove)
            {
                base.DbSet.Remove(cyclist);
            }
        }
    }
}
