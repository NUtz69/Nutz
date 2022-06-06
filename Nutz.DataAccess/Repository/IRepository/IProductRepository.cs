using Nutz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Repository.IRepository
{
    // 002 - Product Management
    public interface IProductRepository : IRepository<Product>
    {
        // Update
        void Update(Product obj);
    }
}
