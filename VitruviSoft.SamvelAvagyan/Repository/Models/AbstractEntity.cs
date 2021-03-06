using System;

namespace VitruviSoft.SamvelAvagyan.Repository.Models
{
    public class AbstractEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; } 
        public DateTime ModifiedOn { get; set; }
    }
}
