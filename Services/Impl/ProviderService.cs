using System.Collections.Generic;
using System.Linq;
using VitruviSoft.SamvelAvagyan.Repository;
using VitruviSoft.SamvelAvagyan.Repository.Models;

namespace VitruviSoft.SamvelAvagyan.Services.Impl
{
    public class ProviderService : BaseService<Provider>, IProviderService
    {
        private readonly IProviderRepository providerRepository;
        private readonly IBaseRepository<Provider> baseRepository;

        public ProviderService(IProviderRepository providerRepository, IBaseRepository<Provider> baseRepository)
            :base(baseRepository)
        {
            this.providerRepository = providerRepository;
            this.baseRepository = baseRepository;
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
