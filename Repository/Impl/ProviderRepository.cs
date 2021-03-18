using Serilog;
using VitruviSoft.SamvelAvagyan.Repository.Models;

namespace VitruviSoft.SamvelAvagyan.Repository.Impl
{
    public class ProviderRepository : BaseRepository<Provider>, IProviderRepository
    {
        public ProviderRepository(DatabaseContext dbContext, ILogger logger)
            : base(dbContext, logger)
        { }
    }
}
