using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycling.Models
{
    public class Town
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Cyclist> Cyclists { get; set; }

        public virtual Town Municipality { get; set; }
    }
}
