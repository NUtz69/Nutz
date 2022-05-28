using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Respository.IRespository
{
    // 002 - Product Management
    public interface IRespository<T> where T : class
    {
        // T - Category

        // GetFirstOrDefault
        T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null);
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
