namespace Cycling.Data.Postgre.Migrations
{
    using Models.PostgreSQL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Cycling.Data.Postgre.CyclingDbContextPostgre>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Cycling.Data.Postgre.CyclingDbContextPostgre context)
        {
            var championship = new Championship();
                championship.Name = "World Championship";

            var sponsor = new Sponsor();
            sponsor.Name = "Union Cycliste Internationale";

            using (var dbContext = new CyclingDbContextPostgre())
            {
                dbContext.Championships.Add(championship);
                dbContext.Sponsors.Add(sponsor);

                dbContext.SaveChanges();
            }
        }
    }
}
