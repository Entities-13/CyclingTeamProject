using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Cycling.Models.SQLite;

namespace Cycling.Data.SQLite
{
    public class DbContextInitializer : SqliteDropCreateDatabaseWhenModelChanges<CyclingDbContextSQLite>
    {
        public DbContextInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder)
        {
        }

        protected override void Seed(CyclingDbContextSQLite context)
        {
            var destination = new CyclingDestination();
            destination.Name = "Somewhere in Pirin";
            destination.Country = "Bulgaria";

            var instructor = new CyclingInstructor();
            instructor.Name = "Nikodim Nikodimov";
            instructor.Country = "Bulgaria";

            context.Set<CyclingDestination>().Add(destination);
            context.Set<CyclingInstructor>().Add(instructor);
        }
    }
}
