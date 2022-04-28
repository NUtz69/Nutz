using Nutz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Respository.IRespository
{
    // 001 - Repository Pattern
    public interface ICategoryRespository : IRespository<Category>
    {
        // Update
        void Update(Category obj);
    }
}
