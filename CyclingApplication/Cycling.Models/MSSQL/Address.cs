using System.ComponentModel.DataAnnotations;

namespace Cycling.Models.MSSQL
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        public virtual Town Town { get; set; }
    }
}
