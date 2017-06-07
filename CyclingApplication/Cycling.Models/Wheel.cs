namespace Cycling.Models
{
    public class Wheel
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public int Size { get; set; }

        public virtual Tire Tire { get; set; }
    }
}
