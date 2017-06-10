using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cycling.Models.MSSQL
{
    public class Bicycle
    {
        private ICollection<Cyclist> cyclist;

        public Bicycle()
        {
            this.cyclist = new HashSet<Cyclist>();
        }

        public int Id { get; set; }

        [MaxLength(40)]
        [Required]
        public string Brand { get; set; }

        [MaxLength(40)]
        [Required]
        public string Model { get; set; }

        public virtual ICollection<Cyclist> Cyclist
        {
            get { return cyclist; }
            set { cyclist = value; }
        }

        public virtual Wheel Wheel { get; set; }
    }
}
