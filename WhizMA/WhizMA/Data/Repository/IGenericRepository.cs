using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WhizMA.Data.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes);
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> voorwaarden);
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> voorwaarden, params Expression<Func<TEntity, object>>[] includes);
        Task<TEntity> GetById(int id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
