using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycling.Data.Postgre
{
    public class CyclingDbContextPostgre : DbContext
    {
        public CyclingDbContextPostgre()
            : base("CyclingPostgresDB")
        {
        }


    }
}
