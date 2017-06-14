using Cycling.Models.MSSQL;
using System.Collections.Generic;

namespace Cycling.Web.Contracts
{
    public interface ICreateCyclist
    {
        void CreateMany(ICollection<Cyclist> cyclists);
        void CreateOne(string firstName, string lastName, int age, int tourWins, int giroWins, int vueltaWins, string team);
    }
}