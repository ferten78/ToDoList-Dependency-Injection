using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
        where TContext : System.Data.Entity.DbContext, new()
    {
        public TEntity Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

                return entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
                 
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> Filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(Filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> Filter = null)
        {
            using (var context = new TContext())
            {
                return Filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(Filter).ToList();
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();

                return entity;
            }
        }
    }
}
