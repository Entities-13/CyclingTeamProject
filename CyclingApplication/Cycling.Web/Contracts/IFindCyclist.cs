using System.Collections.Generic;
using Cycling.Models.MSSQL;

namespace Cycling.Web.Contracts
{
    public interface IFindCyclist
    {
        IEnumerable<Cyclist> Find();
    }
}