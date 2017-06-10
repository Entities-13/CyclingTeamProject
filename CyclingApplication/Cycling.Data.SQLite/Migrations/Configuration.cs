namespace Cycling.Data.SQLite.Migrations
{
    using Models.SQLite;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Cycling.Data.SQLite.CyclingDbContextSQLite>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Cycling.Data.SQLite.CyclingDbContextSQLite context)
        {
            var destination = new CyclingDestination();
            destination.Name = "Somewhere in Pirin";
            destination.Country = "Bulgaria";

            var instructor = new CyclingInstructor();
            instructor.Name = "Nikodim Nikodimov";
            instructor.Country = "Bulgaria";

            using (var dbContext = new CyclingDbContextSQLite())
            {
                dbContext.CyclingDestination.Add(destination);
                dbContext.CyclingInstructors.Add(instructor);

                dbContext.SaveChanges();
            }
        }
    }
}
