using System.Collections.Generic;
using VitruviSoft.SamvelAvagyan.Repository.Models;

namespace VitruviSoft.SamvelAvagyan.Services
{
    public interface IProviderService : IBaseService<Provider>
    {
        IEnumerable<string> ProvidersNames(int groupId);
     }
}
