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
        private const string invalidNameMessage = "Names must be more than 3 and less than 40 sumbols, only Latyn symbols, not separated by any symbol";
        private const string invalidNationalityMessage = "Nationality must be more than 3 and less than 40 sumbols, only latin symbols, separeted by comma";


        public int Id { get; set; }

        [MaxLength(40)]
        [RegularExpression("^[A-Za-z]{3,40}$", ErrorMessage = invalidNameMessage)]
        public string FirstName { get; set; }

        [MaxLength(40)]
        [RegularExpression("^[A-Za-z]{3,40}$", ErrorMessage = invalidNameMessage)]
        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        [MaxLength(40)]
        [RegularExpression("^[A-Za-z ]{3,40}$", ErrorMessage = invalidNationalityMessage)]
        public string Nationality { get; set; }

        public virtual ICollection<TourDeFrance> TF_Id { get; set; }
        public virtual ICollection<GiroDItalia> GI_Id { get; set; }
    }
}
