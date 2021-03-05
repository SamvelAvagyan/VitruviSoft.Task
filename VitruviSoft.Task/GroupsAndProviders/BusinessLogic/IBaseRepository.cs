using System.Linq;

namespace BusinessLogic
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();
    }
}
