using Cycling.Data;
using Cycling.Data.Common;
using Cycling.Models.MSSQL;
using System.Collections.Generic;
using System.Linq;

namespace Cycling.Web.DataProviders
{
    public class DisplayCyclists
    {
        public IEnumerable<Cyclist> Display()
        {
            using (var unitOfWork = new EfUnitOfWork(new CyclingDbContext())) 
            {
                return unitOfWork.CyclistsRepository.GetAll().ToList();
            }
        }
    }
}