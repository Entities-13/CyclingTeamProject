using Cycling.Data;
using Cycling.Data.Common;
using Cycling.Models.MSSQL;
using Cycling.Web.Contracts;
using System.Collections.Generic;

namespace Cycling.Web.DataProviders
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
            using (var unitOfWork = new EfUnitOfWork(new CyclingDbContext()))
            {
                var cyclistObj = unitOfWork.CyclistsRepository.GetById(this.CyclistId);
                var cyclistCollection = new List<Cyclist>() { cyclistObj };

                return cyclistCollection;
            }
        }
    }
}