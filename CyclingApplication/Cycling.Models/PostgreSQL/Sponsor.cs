using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cycling.Models.PostgreSQL
{
    public class Sponsor
    {
        public Sponsor()
        {
            this.Championships = new HashSet<Championship>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Championship> Championships { get; set; }
    }
}
