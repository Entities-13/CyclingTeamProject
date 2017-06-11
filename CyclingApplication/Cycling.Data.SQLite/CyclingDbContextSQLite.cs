using Cycling.Models.SQLite;
using SQLite.CodeFirst;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var sqliteConnectionInitializer = new SqliteDropCreateDatabaseWhenModelChanges<CyclingDbContextSQLite>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }
    }
}
