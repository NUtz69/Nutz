using Nutz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Respository.IRespository
{
    // 002 - Product Management
    public interface IProductRespository : IRespository<Product>
    {
        // Update
        void Update(Product obj);
    }
}
