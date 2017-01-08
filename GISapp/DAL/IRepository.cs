using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace DAL
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        TEntity Get(params object[] id);
        TEntity Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        int DeleteByWhereCondition(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, params string[] navigationProperties);
    }
}
