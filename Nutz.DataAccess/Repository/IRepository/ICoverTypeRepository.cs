using Nutz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Repository.IRepository
{
    // 001 - Repository Pattern
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        // Update
        void Update(CoverType obj);
    }
}
