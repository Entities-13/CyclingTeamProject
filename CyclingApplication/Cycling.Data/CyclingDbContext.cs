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

        public virtual IDbSet<Cyclist> Cyclists { get; set; }

        public virtual IDbSet<Bicycle> Bicycles { get; set; }
    }
}
