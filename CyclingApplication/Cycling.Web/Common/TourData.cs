using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cycling.Web.Common
{
    public class TourData
    {
        public DateTime Year { get; set; }

        public int EtapsCount { get; set; }

        public int Distance { get; set; }

        public TimeSpan TimeOfWinner { get; set; }

        public string FullName { get; set; }

        public string Nationalite { get; set; }

        public DateTime BirtdayOfWinner { get; set; }
    }
}