using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VitruviSoft.SamvelAvagyan.Repository;
using VitruviSoft.SamvelAvagyan.Repository.Models;

namespace VitruviSoft.SamvelAvagyan.Services.Impl
{
    public class BaseService<T> : IBaseService<T>
        where T : AbstractEntity
    {
        private readonly IBaseRepository<T> repository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            this.repository = baseRepository;
        }

        public IEnumerable<T> Actives()
        {
            return repository.Actives();
        }

        public IEnumerable<T> All()
        {
            return repository.All();
        }

        public IEnumerable<T> Deleted()
        {
            return repository.Deleted();
        }

        public T GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Add(T model)
        {
            model.Active = true;
            model.ModifiedOn = DateTime.Now;
            model.CreatedOn = DateTime.Now;
            repository.Add(model);
        }

        public bool Delete(int id)
        {
            return repository.Delete(id);
        }

        public async Task<IEnumerable<T>> AllAsync()
        {
            return await repository.AllAsync();
        }

        public async Task<IEnumerable<T>> ActivesAsync()
        {
            return await repository.ActivesAsync();
        }

        public async Task<IEnumerable<T>> DeletedAsync()
        {
            return await repository.DeletedAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        public async Task AddAsync(T model)
        {
            model.Active = true;
            model.ModifiedOn = DateTime.Now;
            model.CreatedOn = DateTime.Now;
            await repository.AddAsync(model);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await repository.DeleteAsync(id);
        }
    }
}
