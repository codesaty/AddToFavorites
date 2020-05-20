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
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var contextValue = new TContext())
            {
                return contextValue.Set<TEntity>().SingleOrDefault(filter);
            }
        
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var contextValue = new TContext())
            {
                return filter == null
                    ? contextValue.Set<TEntity>().ToList()
                    : contextValue.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Add(TEntity entity)
        {
            using (var contextValue = new TContext())
            {
                var addedEntities = contextValue.Entry(entity);
                addedEntities.State = EntityState.Added;
                contextValue.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var contextValue = new TContext())
            {
                var deletedEntities = contextValue.Entry(entity);
                deletedEntities.State = EntityState.Deleted;
                contextValue.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var contextValue = new TContext())
            {
                var updatedEntities = contextValue.Entry(entity);
                updatedEntities.State = EntityState.Modified;
                contextValue.SaveChanges();
            }
        }
    }
}
