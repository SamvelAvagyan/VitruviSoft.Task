using System.Collections.Generic;

namespace VitruviSoft.SamvelAvagyan.Services
{
    interface IGroupService
    {
        IEnumerable<string> GetGroupsNames();
    }
}
