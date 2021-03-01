using System.Collections.Generic;

namespace BusinessObjects
{
    public class Group : BaseModel
    {
        public ICollection<Provider> Providers { get; set; }
    }
}
