using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Respository.IRespository
{
    // 002 - Product Management
    public interface IUnitOfWork
    {
        // Get
        ICategoryRespository Category { get; } // Category
        ICoverTypeRespository CoverType { get; } // CoverType
        IProductRespository Product { get; } // Product
        // 004 - Identity Management
        ICompanyRespository Company { get; } // Company

        // Save
        void Save();
    }
}
