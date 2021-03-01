using System.Collections.Generic;

namespace BusinessObjects
{
    public class Group : BaseModel
    {
        public List<Provider> Providers { get; set; }
    }
}
