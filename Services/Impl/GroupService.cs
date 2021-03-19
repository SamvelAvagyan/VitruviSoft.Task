using System.Collections.Generic;
using System.Linq;
using VitruviSoft.SamvelAvagyan.Repository;
using VitruviSoft.SamvelAvagyan.Repository.Models;

namespace VitruviSoft.SamvelAvagyan.Services.Impl
{
    public class GroupService : BaseService<Group>, IGroupService
    {
        private readonly IGroupRepository groupRepository;

        public GroupService(IGroupRepository groupRepository, IBaseRepository<Group> baseRepository)
            : base(baseRepository)
        {
            this.groupRepository = groupRepository;
        }

        public IEnumerable<string> GroupsNames()
        {
            return groupRepository
                .Actives()
                .Select(t => t.Name);
        }
    }
}
