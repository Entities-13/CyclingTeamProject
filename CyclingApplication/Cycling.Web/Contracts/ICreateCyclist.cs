using Cycling.Models.MSSQL;
using System.Collections.Generic;

namespace Cycling.Web.Contracts
{
    public interface ICreateCyclist
    {
        int Age { get; set; }
        string CurrentTeam { get; set; }
        ICollection<Cyclist> Cyclists { get; set; }
        string FirstName { get; set; }
        int GiroDItaliaWins { get; set; }
        string LastName { get; set; }
        int TourDeFranceWins { get; set; }
        int VueltaWins { get; set; }

        void CreateMany();
        void CreateOne();
    }
}