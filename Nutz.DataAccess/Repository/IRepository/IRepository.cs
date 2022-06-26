using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Repository.IRepository
{
    // 002 - Product Management
    public interface IRepository<T> where T : class
    {
        // T - Category

        // GetFirstOrDefault
        T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = true); // 007 - Order Management
        // GetAll
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null); // 005 - Shopping Cart
        // Add
        void Add(T entity);
        // Remove
        void Remove(T entity);
        // Remove Range
        void RemoveRange(IEnumerable<T> entity);
    }
}
