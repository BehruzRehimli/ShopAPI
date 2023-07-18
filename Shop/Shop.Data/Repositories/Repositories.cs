using Microsoft.EntityFrameworkCore;
using Shop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repositories
{
    public class Repositories<TEntity> : IRepository<TEntity> where TEntity:class
    {
        private readonly ShopDBContext _context;

        public Repositories(ShopDBContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public int Commit()
        {
           return _context.SaveChanges();
        }

        public TEntity Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> exp, params string[] includes)
        {
            var query= _context.Set<TEntity>().AsQueryable();
            foreach (var item in includes)
            {
                query = query.Include(item);
            }
            return query.FirstOrDefault(exp);
        }

        public IQueryable<TEntity> GetQueryable(System.Linq.Expressions.Expression<Func<TEntity, bool>> exp, params string[] includes)
        {
            var query = _context.Set<TEntity>().AsQueryable();
            foreach (var item in includes)
            {
                query = query.Include(item);
            }
            return query.Where(exp);
        }

        public bool IsExist(System.Linq.Expressions.Expression<Func<TEntity, bool>> exp)
        {
            return _context.Set<TEntity>().Any(exp);
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
    }
}
