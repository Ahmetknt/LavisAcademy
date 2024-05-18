using LavisAcademy.Models.Interface;
using System.Linq.Expressions;
using System.Security.Principal;

namespace LavisAcademy.Core
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
