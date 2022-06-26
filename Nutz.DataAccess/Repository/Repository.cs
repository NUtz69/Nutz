using Microsoft.EntityFrameworkCore;
using Nutz.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Repository
{
    // 002 - Product Management
    public class Repository<T> : IRepository<T> where T : class
    {
        // Var
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        // ctor
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            /*_db.ShoppingCarts.AsNoTracking();*/ // 007 - Order Management
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
        public T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = true) // 007 - Order Management
        {
            IQueryable<T> query;

            // 007 - Order Management
            if (tracked)
            {
                query = dbSet;
            }
            else
            {
                query = dbSet.AsNoTracking();
            }

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
