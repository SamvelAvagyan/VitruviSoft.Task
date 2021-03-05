namespace BusinessObjects
{
    public class Provider : BaseModel
    {
        public int? GroupId { get; set; }
        public Group Group { get; set; }
    }
}
