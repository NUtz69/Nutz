using Microsoft.EntityFrameworkCore;
using Nutz.DataAccess.Respository.IRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Respository
{
    // 001 - Repository Pattern
    public class Respository<T> : IRespository<T> where T : class
    {
        // Var
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        // ctor
        public Respository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        // Add
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        // GetAll
        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;

            return query.ToList();
        }

        // GetFirstOrDefault
        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);

            return query.FirstOrDefault();
        }

        // Remove
        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        // Remove Range
        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
}
