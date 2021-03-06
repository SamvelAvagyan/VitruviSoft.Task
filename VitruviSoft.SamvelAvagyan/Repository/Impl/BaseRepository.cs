using System.Linq;
using VitruviSoft.SamvelAvagyan.Repository.Models;

namespace VitruviSoft.SamvelAvagyan.Repository.Impl
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : AbstractEntity
    {
        private readonly DatabaseContext dbContext;

        public BaseRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<T> Actives()
        {
            return All().Where(t => t.Active);
        }

        public void Add(T model)
        {
            dbContext.Set<T>().Add(model);
            dbContext.SaveChanges();
        }

        public IQueryable<T> All()
        {
            return dbContext.Set<T>();
        }

        public IQueryable<T> Deleted()
        {
            return All().Where(t => !t.Active);
        }
    }
}
