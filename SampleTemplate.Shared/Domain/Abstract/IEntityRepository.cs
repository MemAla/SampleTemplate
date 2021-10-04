using SampleTemplate.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SampleTemplate.Shared.Domain.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        #region Async
        Task<T> GetAsync(Expression<Func<T,bool>> predicate, params Expression<Func<T,object>>[] includeProperties);//var kullanici=repository.GetAsync(x=>x.Id==15)

        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null, 
            params Expression<Func<T, object>>[] includeProperties);

        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);

        #endregion

        T FindByGuidId(Guid id);


        T FindByIntId(int id);

        T FindByStringId(string id);
        IQueryable<T> FindAll();


        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);

        IQueryable<T> FindByConditionTrackable(Expression<Func<T, bool>> expression);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);

        T Save(T entity);

        void AddAll(IEnumerable<T> entities);

        void SaveDb();

        void RemoveAll(IEnumerable<T> entities);

        T GetById(int id);

    }
}
