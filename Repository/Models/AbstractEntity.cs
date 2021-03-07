using System;

namespace VitruviSoft.SamvelAvagyan.Repository.Models
{
    public class AbstractEntity
    {
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; } 
        public DateTime ModifiedOn { get; set; }
    }
}
