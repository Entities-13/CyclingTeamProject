using System.ComponentModel.DataAnnotations;

namespace Cycling.Models
{
    public class Cyclist
    {
        public int Id { get; set; }

        [MaxLength(40)]
        public string FirstName { get; set; }

        [MaxLength(40)]
        public string LastName { get; set; }

        public int Age { get; set; }

        public int TourDeFranceWins { get; set; }

        public int GiroDItaliaWins { get; set; }

        public int VueltaEspanaWins { get; set; }

        [MaxLength(50)]
        public string CurrentTeam { get; set; }
    }
}
