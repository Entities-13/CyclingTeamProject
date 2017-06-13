using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cycling.Models.MSSQL;

namespace Cycling.Models
{
    public abstract class CiclingTour
    {
        public int Id { get; set; }

        [Index]
        public DateTime Year { get; set; }

        public int Stage { get; set; }

        public int Distance { get; set; }

        //[Column(TypeName = "timestamp")]
        public double TimeOfWinner { get; set; }

        public virtual CyclistNext CyclistNext_Id { get; set; }
    }
}
