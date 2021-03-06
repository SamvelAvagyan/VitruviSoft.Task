using System.Linq;

namespace VitruviSoft.SamvelAvagyan.Repository
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> All();
        IQueryable<T> Actives();
        IQueryable<T> Deleted();
        void Add(T model);
    }
}
