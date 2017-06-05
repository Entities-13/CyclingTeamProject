using Cycling.Models;
using System.Data.Entity;

namespace Cycling.Data
{
    public class CyclingDbContext : DbContext
    {
        public CyclingDbContext() 
            : base("CyclingDB")
        {
        }

        public DbSet<Cyclist> Cyclists { get; set; }

    }
}
