using BusinessObjects;
using Data;

namespace BusinessLogic.Impl
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        public GroupRepository(DatabaseContext dbContext)
            : base(dbContext)
        { }
    }
}
