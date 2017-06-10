using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cycling.Models.MSSQL
{
    public class Cyclist
    {
        private ICollection<Bicycle> bicycle;

        public Cyclist()
        {
            this.bicycle = new HashSet<Bicycle>();
        }

        public int Id { get; set; }

        [MaxLength(40)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(40)]
        [Required]
        public string LastName { get; set; }

        public int Age { get; set; }

        public int TourDeFranceWins { get; set; }

        public int GiroDItaliaWins { get; set; }

        public int VueltaEspanaWins { get; set; }

        [MaxLength(50)]
        public string CurrentTeam { get; set; }

        public virtual ICollection<Bicycle> Bicycle
        {
            get { return bicycle; }
            set { bicycle = value; }
        }

    }
}