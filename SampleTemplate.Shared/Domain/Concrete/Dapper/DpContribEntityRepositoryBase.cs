using Dapper.Contrib.Extensions;
using SampleTemplate.Shared.Domain.Abstract;
using SampleTemplate.Shared.Entities.Abstract;
using SampleTemplate.Shared.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace  SampleTemplate.Shared.Domain.Concrete
{
    public class DpContribEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        public  TEntity GetById(int id)
        {
            using (var db = GetConnection.GetConnectionString())
            {
              return db.Get<TEntity>(id);
            }
        }
        
        public async Task AddAsync(TEntity entity)
        {
            using (var db = GetConnection.GetConnectionString())
            {
               await db.InsertAsync<TEntity>(entity);
            }
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using (var db = GetConnection.GetConnectionString())
            {
                await db.DeleteAsync(entity);
            }
        }

        public async Task DeleteById(object id)
        {
            using (var db = GetConnection.GetConnectionString())
            {
                await db.DeleteAsync(id);
            }
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using (var db = GetConnection.GetConnectionString())
            {
                await db.UpdateAsync(entity);
            }
        }
      
        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            bool isAveilable = false;

            using (var db=GetConnection.GetConnectionString())
            {
                //string query = $"select count(*) from {typeof(TEntity).Name}s where ";
                //var _predicate = Predicates.Field<TEntity>(predicate, Operator.Eq, true);
              
                //return cn.GetList<T>(predicate);
            }

            return isAveilable;
        }

        public Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public TEntity FindByGuidId(Guid id)
        {
            throw new NotImplementedException();
        }

        public TEntity FindByIntId(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity FindByStringId(string id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> FindAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> FindByConditionTrackable(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Save(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void AddAll(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void SaveDb()
        {
            throw new NotImplementedException();
        }

        public void RemoveAll(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
