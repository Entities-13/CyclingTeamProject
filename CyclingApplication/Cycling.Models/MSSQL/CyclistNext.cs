using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cycling.Models.MSSQL
{
    public class CyclistNext
    {
        private const string invalidNameMessage = "Names must be more than 3 and less than 40 sumbols, only Latyn symbols, not separated by any symbol";
        private const string invalidNationalityMessage = "Nationality must be more than 3 and less than 40 sumbols, only latin symbols, separeted by comma";
        private const string patternNames = "^[a-zA-Zà-ÿÀ-Ÿ]{3,40}$";

        public CyclistNext()
        {
            this.TF_Id = new HashSet<TourDeFrance>();
            this.GI_Id = new HashSet<GiroDItalia>();
        }
        public int Id { get; set; }

        [MaxLength(40)]
        //[RegularExpression(patternNames, ErrorMessage = invalidNameMessage)]
        public string FirstName { get; set; }

        [MaxLength(40)]
        //[RegularExpression(patternNames, ErrorMessage = invalidNameMessage)]
        public string LastName { get; set; }

        public DateTime BirthDay { get; set; }

        [MaxLength(40)]
        //[RegularExpression("^[A-Za-z ]{3,40}$", ErrorMessage = invalidNationalityMessage)]
        public string Nationality { get; set; }

        public virtual ICollection<TourDeFrance> TF_Id { get; set; }
        public virtual ICollection<GiroDItalia> GI_Id { get; set; }
    }
}