using BusinessObjects;
using Data;

namespace BusinessLogic.Impl
{
    public class ProviderRepository : BaseRepository<Provider>, IProviderRepository
    {
        public ProviderRepository(DatabaseContext dbContext)
            : base(dbContext)
        { }
    }
}
