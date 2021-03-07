using System.Linq;
using System.Threading.Tasks;

namespace VitruviSoft.SamvelAvagyan.Repository
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> All();
        IQueryable<T> Actives();
        IQueryable<T> Deleted();
        T GetById(int id);
        void Add(T model);
        bool Delete(int id);
        Task<IQueryable<T>> AllAsync();
        Task<IQueryable<T>> ActivesAsync();
        Task<IQueryable<T>> DeletedAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T model);
        Task<bool> DeleteAsync(int id);
    }
}
