﻿using Serilog;
using VitruviSoft.SamvelAvagyan.Repository.Models;

namespace VitruviSoft.SamvelAvagyan.Repository.Impl
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        public GroupRepository(DatabaseContext dbContext, ILogger logger)
            : base(dbContext, logger)
        { }
    }
}
