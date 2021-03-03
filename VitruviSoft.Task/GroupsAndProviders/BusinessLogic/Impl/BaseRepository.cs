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

        public void Add(T model)
        {
            dbContext.Set<T>().Add(model);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            dbContext.Set<T>().Remove(GetById(id));
            dbContext.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return dbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public void Update(T model)
        {
            dbContext.Set<T>().Update(model);
            dbContext.SaveChanges();
        }
    }
}
