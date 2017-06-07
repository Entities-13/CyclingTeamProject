using System.ComponentModel.DataAnnotations;

namespace Cycling.Models
{
    public class Tire
    {
        public int Id { get; set; }

        [MaxLength(40)]
        [Required]
        public string Brand { get; set; }

        public int Size { get; set; }
    }
}
