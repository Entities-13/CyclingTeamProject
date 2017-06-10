using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cycling.Models.SQLite
{
    public class CyclingInstructor
    {
        public CyclingInstructor()
        {
            this.CyclingDestinations = new HashSet<CyclingDestination>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country { get; set; }

        public virtual ICollection<CyclingDestination> CyclingDestinations { get; set; }
    }
}
