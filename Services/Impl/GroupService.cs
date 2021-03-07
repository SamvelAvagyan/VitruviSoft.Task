﻿using System.Collections.Generic;
using System.Linq;
using VitruviSoft.SamvelAvagyan.Repository;

namespace VitruviSoft.SamvelAvagyan.Services.Impl
{
    public class GroupService : IGroupService
    {
        private readonly IGroupRepository groupRepository;

        public GroupService(IGroupRepository groupRepository)
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
