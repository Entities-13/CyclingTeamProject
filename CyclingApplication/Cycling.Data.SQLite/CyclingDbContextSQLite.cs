using Cycling.Models.SQLite;
using System.Data.Entity;

namespace Cycling.Data.SQLite
{
    public class CyclingDbContextSQLite : DbContext
    {
        public CyclingDbContextSQLite()
            : base("CyclingSqliteDB")
        {
        }

        public virtual IDbSet<CyclingInstructor> CyclingInstructors { get; set; }

        public virtual IDbSet<CyclingDestination> CyclingDestination { get; set; }
    }
}
