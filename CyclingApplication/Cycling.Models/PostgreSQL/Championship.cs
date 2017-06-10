using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cycling.Models.PostgreSQL
{
    public class Championship
    {
        public Championship()
        {
            this.Sponsors = new HashSet<Sponsor>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Sponsor> Sponsors { get; set; }
    }
}
