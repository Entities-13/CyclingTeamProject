using Cycling.Models.MSSQL;
using System.Data.Entity;
using Cycling.Models;

namespace Cycling.Data
{
    public class CyclingDbContext : DbContext
    {
        public CyclingDbContext()
            : base("CyclingDB")
        {
        }

        public virtual IDbSet<Cyclist> Cyclists { get; set; }

        public virtual IDbSet<Bicycle> Bicycles { get; set; }

        public virtual IDbSet<Wheel> Wheels { get; set; }

        public virtual IDbSet<Tire> Tires { get; set; }

        public virtual IDbSet<Town> Towns { get; set; }

        public virtual IDbSet<Address> Addresses { get; set; }

        public virtual IDbSet<TourDeFrance> TourDeFrance { get; set; }

        public virtual IDbSet<GiroDItalia> GiroDItalia { get; set; }

        public virtual IDbSet<CyclistNext> CylistNext { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            this.OnTownModelCreating(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void OnTownModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Town>().HasKey(town => town.Id);

            modelBuilder.Entity<Town>().Property(town => town.Name).IsRequired();

            modelBuilder.Entity<Town>().Property(town => town.Name).HasMaxLength(40);

            modelBuilder.Entity<Town>().Property(town => town.Population).IsOptional();
        }
    }
}
