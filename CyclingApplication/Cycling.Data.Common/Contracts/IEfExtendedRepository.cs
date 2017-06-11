using Cycling.Models.MSSQL;

namespace Cycling.Data.Common.Contracts
{
    public interface IEfExtendedRepository : IRepository<Cyclist>
    {
        void RemoveByFirstAndLastName(string firstName, string lastName);
    }
}
