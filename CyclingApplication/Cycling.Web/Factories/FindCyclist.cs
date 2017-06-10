using Cycling.Data;
using Cycling.Models.MSSQL;
using Cycling.Web.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Cycling.Web.Factories
{
    public class FindCyclist : IFindCyclist
    {
        public FindCyclist(int cyclistId)
        {
            this.CyclistId = cyclistId;
        }

        public int CyclistId { get; set; }

        public IEnumerable<Cyclist> Find()
        {
            using (var dbContext = new CyclingDbContext())
            {
                return dbContext.Cyclists.Where(x => x.Id == this.CyclistId).ToList();
            }
        }
    }
}