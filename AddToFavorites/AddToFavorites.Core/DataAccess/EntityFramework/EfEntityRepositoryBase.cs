using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AddToFavorites.Core.DataAccess.EntityFramework
{

    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, new()
    where TContext : DbContext, new()
    {
        private readonly NorthwindContext _contextValue;
        public EfEntityRepositoryBase(NorthwindContext contextValue)
        {
             _context=context;        
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
           
                return _contextValue.Set<TEntity>().SingleOrDefault(filter);
            
        
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
           
                return filter == null
                    ? _contextValue.Set<TEntity>().ToList()
                    : _contextValue.Set<TEntity>().Where(filter).ToList();
            
        }

        public void Add(TEntity entity)
        {
          
                var addedEntities = _contextValue.Entry(entity);
                addedEntities.State = EntityState.Added;
                _contextValue.SaveChanges();
            
        }

        public void Delete(TEntity entity)
        {          
                var deletedEntities = _contextValue.Entry(entity);
                deletedEntities.State = EntityState.Deleted;
                _contextValue.SaveChanges();            
        }

        public void Update(TEntity entity)
        {
                var updatedEntities = _contextValue.Entry(entity);
                updatedEntities.State = EntityState.Modified;
                _contextValue.SaveChanges();
            
        }
    }
}
