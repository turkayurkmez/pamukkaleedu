using pamukkaleEdu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace pamukkaleEdu.Data.Repositories
{
   public interface IRepository<T> where T:class, IEntity,new() 
    {
        IEnumerable<T> GetAllEntities();
        Task<IEnumerable<T>> GetAllEntitiesAync();
        Task<T> GetEntityById(int id);
        IEnumerable<T> GetEntitiesWithCredential(Expression<Func<T, bool>> predicate);

        Task<T> AddEntity(T newEntity);
        Task<T> UpdateEntity(T newEntity);

        Task<int> Delete(T entity);
        Task<int> Delete(int id);

    }
}
