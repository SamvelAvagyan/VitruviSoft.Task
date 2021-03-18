using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VitruviSoft.SamvelAvagyan.Services
{
    public interface IBaseService<T>
    {
        IEnumerable<T> All();
        IEnumerable<T> Actives();
        IEnumerable<T> Deleted();
        T GetById(int id);
        void Add(T model);
        bool Delete(int id);
        void Update(T model);
        Task<IEnumerable<T>> AllAsync();
        Task<IEnumerable<T>> ActivesAsync();
        Task<IEnumerable<T>> DeletedAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T model);
        Task<bool> DeleteAsync(int id);
        Task UpdateAsync(T model);
    }
}
