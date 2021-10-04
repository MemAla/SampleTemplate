using Microsoft.EntityFrameworkCore;
using SampleTemplate.Shared.Domain.Abstract;
using SampleTemplate.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SampleTemplate.Shared.Domain.Concrete
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        protected DbContext _dbContext;
       
        public EfEntityRepositoryBase(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #region Async
        public async Task AddAsync(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbContext.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbContext.Set<TEntity>().CountAsync(predicate);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() =>
            {
                _dbContext.Set<TEntity>().Remove(entity);
            });
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();
            if (predicate!=null)
            {
                query.Where(predicate);
            }
            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query.Include(includeProperty);
                }
            }
            return await query.ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = _dbContext.Set<TEntity>();
            if (predicate != null)
            {
                query.Where(predicate);
            }
            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query.Include(includeProperty);
                }
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() =>
            {
                _dbContext.Set<TEntity>().Update(entity);
            });
        }

        #endregion

        public TEntity FindByGuidId(Guid id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public TEntity FindByIntId(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public TEntity FindByStringId(string id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }
        public IQueryable<TEntity> FindAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return _dbContext.Set<TEntity>().Where(expression).AsNoTracking();
        }

        public IQueryable<TEntity> FindByConditionTrackable(Expression<Func<TEntity, bool>> expression)
        {
            return _dbContext.Set<TEntity>().Where(expression);
        }

        public void Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);

        }

        public void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public TEntity Save(TEntity entity)
        {
            _dbContext.SaveChanges();
            return entity;
        }

        public void AddAll(IEnumerable<TEntity> entities)
        {
            _dbContext.Set<TEntity>().AddRange(entities);
        }

        public void SaveDb()
        {
            _dbContext.SaveChanges();
        }

        public void RemoveAll(IEnumerable<TEntity> entities)
        {
            _dbContext.Set<TEntity>().RemoveRange(entities);
        }

        public TEntity GetById(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

    }
}
