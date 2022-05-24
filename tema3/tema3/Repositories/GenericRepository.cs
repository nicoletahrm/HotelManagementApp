using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace tema3.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _appDbContext;

        private DbSet<T> table;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            table = _appDbContext.Set<T>();
        }

        public void Delete(T obj)
        {
            table.Remove(obj);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return table;
        }

        public IEnumerable<T> GetByCondition(Expression<Func<T, bool>> predicate = null)
        {
            return table.Where(predicate);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
            _appDbContext.SaveChanges();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            table.Update(obj);
            _appDbContext.SaveChanges();
        }
    }
}
