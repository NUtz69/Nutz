using Nutz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Repository.IRepository
{
    // 001 - Repository Pattern
    public interface IOrderHeaderRespository : IRepository<Category>
    {
        // Update
        void Update(Category obj);
    }
}
