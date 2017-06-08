using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycling.Models
{
    public class GiroDItalia : CiclingTour
    {
        [NotMapped]
        public string NameOfTour => "Giro Di Italia";
    }
}
