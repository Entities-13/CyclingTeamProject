using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cycling.Models.MSSQL
{
    public class CyclistNext
    {
        private const string invalidName = "Names must be more than 3 and less than 40 sumbols, start with uppaercase and follow by lowercase";

        public int Id { get; set; }

        [RegularExpression("^[A-Z][a-z]{2,40}$", ErrorMessage = invalidName)]
        public string FirstName { get; set; }

        [RegularExpression("^[A-Z][a-z]{2,40}$", ErrorMessage = invalidName)]
        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        public string Nationality { get; set; }

        public virtual ICollection<TourDeFrance> TF_Id { get; set; }
        public virtual ICollection<GiroDItalia> GI_Id { get; set; }
    }
}
