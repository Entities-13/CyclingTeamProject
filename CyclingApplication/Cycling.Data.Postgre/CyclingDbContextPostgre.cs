using Cycling.Models.PostgreSQL;
using System.Data.Entity;

namespace Cycling.Data.Postgre
{
    public class CyclingDbContextPostgre : DbContext
    {
        public CyclingDbContextPostgre()
            : base("CyclingPostgresDB")
        {
        }

        public virtual IDbSet<Championship> Championships { get; set; }

        public virtual IDbSet<Sponsor> Sponsors { get; set; }
    }
}
