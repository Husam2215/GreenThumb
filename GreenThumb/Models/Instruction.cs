namespace GreenThumb.Models
{
    public class Instruction
    {

        public int Id { get; set; }

        public string Instrtuction { get; set; }

        public int PlantId { get; set; }

        public Plants Plant { get; set; }


    }
}
