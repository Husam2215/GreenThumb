namespace GreenThumb.Models
{
    public class Instructions
    {

        public int Id { get; set; }

        public string Instruction { get; set; }

        public int PlantId { get; set; }

        public Plants Plant { get; set; }


    }
}
