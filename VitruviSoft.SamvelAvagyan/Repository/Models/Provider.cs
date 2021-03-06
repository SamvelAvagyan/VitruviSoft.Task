namespace VitruviSoft.SamvelAvagyan.Repository.Models
{
    public class Provider : AbstractEntity
    {
        public int? GroupId { get; set; }
        public Group Group { get; set; }
    }
}
