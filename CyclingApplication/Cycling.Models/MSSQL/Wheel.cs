using System.ComponentModel.DataAnnotations;

namespace Cycling.Models.MSSQL
{
    public class Wheel
    {
        public int Id { get; set; }

        [MaxLength(40)]
        [Required]
        public string Brand { get; set; }

        [Required]
        public int Size { get; set; }

        public virtual Tire Tire { get; set; }
    }
}
