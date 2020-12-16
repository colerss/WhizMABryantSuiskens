using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WhizMA.Data.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly WhizMAContext _context;

        public GenericRepository(WhizMAContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public IQueryable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includes)
        {
            return GetAll(null, includes);
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> voorwaarden)
        {
            return GetAll(voorwaarden, null);
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> voorwaarden, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (includes != null)
            {
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }
            }
            if (voorwaarden != null)
            {
                query = query.Where(voorwaarden);
            }
            IQueryable<TEntity> query2 = query;
            return query2;
        }
    }
}
