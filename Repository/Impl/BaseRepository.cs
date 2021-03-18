using Serilog;
using System;
using System.Linq;
using System.Threading.Tasks;
using VitruviSoft.SamvelAvagyan.Repository.Models;

namespace VitruviSoft.SamvelAvagyan.Repository.Impl
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : AbstractEntity
    {
        private readonly DatabaseContext dbContext;
        private readonly ILogger logger;

        public BaseRepository(DatabaseContext dbContext, ILogger logger)
        {
            this.dbContext = dbContext;
            this.logger = logger;
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

        public T GetById(int id)
        {
            return All().FirstOrDefault(t => t.Id == id);
        }

        public void Add(T model)
        {
            logger.Information("Start to Add");
            dbContext.Set<T>().Add(model);
            dbContext.SaveChanges();
            logger.Information("End Add");
        }

        public bool Delete(int id)
        {
            logger.Information("Start to Delete");
            var model = GetById(id);
            if (model == null)
                throw new ArgumentException("Invalid Id");
            model.Active = false;
            model.ModifiedOn = DateTime.Now;
            dbContext.Set<T>().Update(model);
            logger.Information("End Delete");
            return dbContext.SaveChanges() == 1;
        }

        public void Update(T model)
        {
            logger.Information("Start to Update");
            dbContext.Set<T>().Update(model);
            dbContext.SaveChanges();
            logger.Information("End Update"); 
        }

        public async Task<IQueryable<T>> AllAsync()
        {
            return await Task.Run(() =>
            {
                return All();
            });
        }

        public async Task<IQueryable<T>> ActivesAsync()
        {
            return await Task.Run(() =>
            {
                return Actives();
            });
        }

        public async Task<IQueryable<T>> DeletedAsync()
        {
            return await Task.Run(() =>
            {
                return Deleted();
            });
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Task.Run(() =>
            {
                return GetById(id);
            });
        }

        public async Task AddAsync(T model)
        {
            dbContext.Set<T>().Add(model);
            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var model = await GetByIdAsync(id);
            if (model == null)
                throw new ArgumentException("Invalid Id");
            model.Active = false;
            model.ModifiedOn = DateTime.Now;
            dbContext.Set<T>().Update(model);
            return await dbContext.SaveChangesAsync() == 1;
        }

        public async Task UpdateAsync(T model)
        {
            Update(model);
            await dbContext.SaveChangesAsync();
        }
    }
}
