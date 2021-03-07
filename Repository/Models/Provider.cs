namespace VitruviSoft.SamvelAvagyan.Repository.Models
{
    public class Provider : AbstractEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
