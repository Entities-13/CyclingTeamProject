using System.ComponentModel.DataAnnotations;

namespace Cycling.Models.MSSQL
{
    public class Tire
    {
        public int Id { get; set; }

        [MaxLength(40)]
        [Required]
        public string Brand { get; set; }

        [Required]
        public int Size { get; set; }
    }
}
