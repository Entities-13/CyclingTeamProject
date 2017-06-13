using System.Collections.Generic;
using Cycling.Models.MSSQL;

namespace Cycling.Web.Contracts
{
    public interface ICreateBicycle
    {
        ICollection<Bicycle> Bicycles { get; set; }

        void CreateMany();
    }
}