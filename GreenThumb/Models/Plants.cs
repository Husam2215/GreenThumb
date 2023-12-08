using System.Collections.Generic;

namespace GreenThumb.Models
{
    public class Plants
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public List<Instructions> instructions { get; set; } = new();
    }
}
