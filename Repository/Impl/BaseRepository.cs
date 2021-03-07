using System;
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

        public IQueryable<T> All()
        {
            return dbContext.Set<T>();
        }

        public IQueryable<T> Deleted()
        {
            return All().Where(t => !t.Active);
        }


        public void Add(T model)
        {
            dbContext.Set<T>().Add(model);
            dbContext.SaveChanges();
        }

        public bool Delete(int id)
        {
            var model = All().FirstOrDefault(p => p.Id == id);
            if (model == null)
                throw new ArgumentException("Invalid Id");
            model.Active = false;
            model.ModifiedOn = DateTime.Now;
            dbContext.Set<T>().Update(model);
            return dbContext.SaveChanges() == 1;
        }
    }
}
