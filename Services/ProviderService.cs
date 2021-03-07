using System.Collections.Generic;
using System.Linq;
using VitruviSoft.SamvelAvagyan.Repository;

namespace VitruviSoft.SamvelAvagyan.Services
{
    public class ProviderService : IProviderService
    {
        private readonly IProviderRepository providerRepository;

        public ProviderService(IProviderRepository providerRepository)
        {
            this.providerRepository = providerRepository;
        }

        public IEnumerable<string> GetProvidersNames(int id)
        {
            return providerRepository
                .Actives()
                .Where(t => t.GroupId == id)
                .Select(t => t.Name);
        }
    }
}
