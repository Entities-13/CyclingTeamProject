namespace Cycling.Models
{
    public class Cyclist
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int TourDeFranceWins { get; set; }

        public int GiroDItaliaWins { get; set; }

        public int VueltaEspanaWins { get; set; }

        public string CurrentTeam { get; set; }
    }
}
