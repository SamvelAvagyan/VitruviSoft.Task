using BusinessObjects;
using Data;
using System.Linq;

namespace BusinessLogic.Impl
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : BaseModel
    {
        private readonly DatabaseContext dbContext;

        public BaseRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<T> GetAll()
        {
            return dbContext.Set<T>();
        }
    }
}
