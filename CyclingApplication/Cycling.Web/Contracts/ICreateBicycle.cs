using System.Collections.Generic;
using Cycling.Models.MSSQL;

namespace Cycling.Web.Contracts
{
    public interface ICreateBicycle
    {
        void CreateMany(ICollection<Bicycle> bicycles);
    }
}