using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VitruviSoft.SamvelAvagyan.Repository;

namespace VitruviSoft.SamvelAvagyan.Services.Impl
{
    public class BaseService<T> : IBaseService<T>
    {
        private readonly IBaseRepository<T> baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public IEnumerable<T> Actives()
        {
            return baseRepository.Actives();
        }

        public IEnumerable<T> All()
        {
            return baseRepository.All();
        }

        public IEnumerable<T> Deleted()
        {
            return baseRepository.Deleted();
        }

        public T GetById(int id)
        {
            return baseRepository.GetById(id);
        }

        public void Add(T model)
        {
            baseRepository.Add(model);
        }

        public bool Delete(int id)
        {
            return baseRepository.Delete(id);
        }

        public async Task<IEnumerable<T>> AllAsync()
        {
            return await baseRepository.AllAsync();
        }

        public async Task<IEnumerable<T>> ActivesAsync()
        {
            return await baseRepository.ActivesAsync();
        }

        public async Task<IEnumerable<T>> DeletedAsync()
        {
            return await baseRepository.DeletedAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await baseRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(T model)
        {
            await baseRepository.AddAsync(model);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await baseRepository.DeleteAsync(id);
        }
    }
}
