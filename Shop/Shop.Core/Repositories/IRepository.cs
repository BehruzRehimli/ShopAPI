using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Repositories
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> GetQueryable(Expression<Func<TEntity, bool>> exp, params string[] includes);
        TEntity Get(Expression<Func<TEntity, bool>> exp, params string[] includes);
        bool IsExist(Expression<Func<TEntity, bool>> exp);
        void Remove(TEntity entity);
        void Add(TEntity entity);
        int Commit();
    }
}
