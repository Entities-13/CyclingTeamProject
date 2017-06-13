using System;

namespace Cycling.Web.Common
{
    public class TourData
    {
        public DateTime Year { get; set; }

        public int EtapsCount { get; set; }

        public int Distance { get; set; }

        public Double TimeOfWinner { get; set; }

        public string FullName { get; set; }

        public string Nationalite { get; set; }

        public DateTime BirtdayOfWinner { get; set; }
    }
}