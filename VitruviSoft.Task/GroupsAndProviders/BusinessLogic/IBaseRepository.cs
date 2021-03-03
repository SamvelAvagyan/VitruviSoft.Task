using System.Linq;

namespace BusinessLogic
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Add(T model);
        void Delete(int id);
        void Update(T model);
    }
}
