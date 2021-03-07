using System.Collections.Generic;

namespace VitruviSoft.SamvelAvagyan.Repository.Models
{
    public class Group : AbstractEntity
    {
        public ICollection<Provider> Providers { get; set; }
    }
}
