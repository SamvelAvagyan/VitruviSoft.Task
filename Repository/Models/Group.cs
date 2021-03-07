using System.Collections.Generic;

namespace VitruviSoft.SamvelAvagyan.Repository.Models
{
    public class Group : AbstractEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public ICollection<Provider> Providers { get; set; }
    }
}
