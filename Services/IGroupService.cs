using System.Collections.Generic;
using VitruviSoft.SamvelAvagyan.Repository.Models;

namespace VitruviSoft.SamvelAvagyan.Services
{
    public interface IGroupService : IBaseService<Group>
    {
        IEnumerable<string> GroupsNames();
    }
}
