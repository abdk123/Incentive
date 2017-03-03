using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Damas.Domain.Interfaces.Repositories;
using Damas.Infrastructure.Context;

namespace Damas.Infrastructure.Repositories
{
    public class RepositoryBase<T> :IDisposable,IRepositoryBase<T> where T : class
    {
        bool _disposed = false;
        readonly DamasContext _context=new DamasContext();
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

       public void Add(T obj)
       {
           _context.Set<T>().Add(obj);
           _context.SaveChanges();
       }

        public void Update(T obj)
        {
            _context.Entry(obj).State=EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remove(T obj)
        {
            _context.Set<T>().Remove(obj);
            _context.SaveChanges();
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                _context.Dispose();
            }
            _disposed = true;
        }
    }
}
