using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Respository.IRespository
{
    // 001 - Repository Pattern
    public interface IUnitOfWork
    {
        // Get
        ICategoryRespository Category { get; } // Category
        ICoverTypeRespository CoverType { get; } // CoverType

        // Save
        void Save();
    }
}
