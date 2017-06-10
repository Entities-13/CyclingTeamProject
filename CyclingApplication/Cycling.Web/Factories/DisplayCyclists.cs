using Cycling.Data;
using Cycling.Models.MSSQL;
using System.Collections.Generic;
using System.Linq;

namespace Cycling.Web.Factories
{
    public class DisplayCyclists
    {
       public IEnumerable<Cyclist> Display()
        {
            using (var dbContext = new CyclingDbContext())
            {
              return dbContext.Cyclists.ToList();
            }
        }
    }
}