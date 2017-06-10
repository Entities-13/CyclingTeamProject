using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cycling.Models.SQLite
{
    public class CyclingDestination
    {
        public CyclingDestination()
        {
            this.CyclingInstructors = new HashSet<CyclingInstructor>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country { get; set; }

        public virtual ICollection<CyclingInstructor> CyclingInstructors { get; set; }
    }
}