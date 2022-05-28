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
    // 002 - Product Management
    public class Respository<T> : IRespository<T> where T : class
    {
        // Var
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        // ctor
        public Respository(ApplicationDbContext db)
        {
            _db = db;
            //_db.ShoppingCarts.Include(u => u.Product).Include(u => u.CoverType);
            this.dbSet = _db.Set<T>();
        }

        // Add
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        // includeProperties - "Category, CoverType"
        // GetAll
        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null) // 005 - Shopping Cart
        {
            IQueryable<T> query = dbSet;
            // 005 - Shopping Cart
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }

            return query.ToList();
        }

        // GetFirstOrDefault
        public T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);

            if (includeProperties != null)
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }

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
