using System.Collections.Generic;
using System.Linq;
using VitruviSoft.SamvelAvagyan.Repository;

namespace VitruviSoft.SamvelAvagyan.Services.Impl
{
    public class ProviderService : IProviderService
    {
        private readonly IProviderRepository providerRepository;

        public ProviderService(IProviderRepository providerRepository)
        {
            this.providerRepository = providerRepository;
        }

        public IEnumerable<string> ProvidersNames(int groupId)
        {
            return providerRepository
                .Actives()
                .Where(t => t.GroupId == groupId)
                .Select(t => t.Name);
        }
    }
}
