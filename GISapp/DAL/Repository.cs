
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Linq.Expressions;
namespace DAL
{
    public class Repository<T>:IRepository<T> where T:class
    {
        private DbContext _context;
        private DbSet<T> _set;
        public Repository()
            : this(new Entities())
        {

        }
        
        public Repository(DbContext context)
        {
            _context = context;
            _set = _context.Set<T>();
        }
        public IQueryable<T> GetAll()
        {
            return _set;
        }

        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return _set.Where(predicate);
        }


        public T Get(params object[] id)
        {
            return _set.Find(id);
        }

        public T Get(bool lazyloading, params object[] id)
        {
            _context.Configuration.LazyLoadingEnabled = lazyloading;
            return _set.Find(id);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate, params string[] navigationProperties)
        {
            var query = _set.AsQueryable();
            foreach (string navigationProperty in navigationProperties)
                query = query.Include(navigationProperty);//got to reaffect it.
            return query.Where(predicate);
        }

        public T Add(T entity)
        {
            T result = null;
            _set.Add(entity);
            if (_context.SaveChanges() > 0)
            {
                result = entity;
            }
            return result;
        }
        public int Add(List<T> entities)
        {
            //T result = null;
            foreach (var entity in entities)
            {
                _set.Add(entity);
                _context.Entry<T>(entity).State = EntityState.Added;
            }
            int affected = _context.SaveChanges();
            return affected;
        }

        public bool Update(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        public bool Delete(T entity)
        {
        
          
            _context.Entry<T>(entity).State = EntityState.Deleted;
            return _context.SaveChanges() > 0;
        }
        public int DeleteByWhereCondition(Expression<Func<T, bool>> predicate)
        {
            _set.RemoveRange(_set.Where(predicate));
            return _context.SaveChanges();
        }

       
    }
}
