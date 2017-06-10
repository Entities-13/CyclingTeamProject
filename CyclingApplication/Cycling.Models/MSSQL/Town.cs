using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycling.Models.MSSQL
{
    public class Town
    {
        public Town()
        {
            this.Cyclist = new HashSet<Cyclist>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Population { get; set; }

        public virtual ICollection<Cyclist> Cyclist { get; set; }
    }
}
