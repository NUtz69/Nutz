using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Repository.IRepository
{
    // 002 - Product Management
    public interface IUnitOfWork
    {
        // Get
        IOrderHeaderRespository Category { get; } // Category
        ICoverTypeRepository CoverType { get; } // CoverType
        IProductRepository Product { get; } // Product
        // 004 - Identity Management
        ICompanyRepository Company { get; } // Company
        // 005 - Shopping Cart
        IShoppingCartRepository ShoppingCart { get; } // ShoppingCart
        IApplicationUserRepository ApplicationUser { get; } // ApplicationUser
        // 006 - Order
        IOrderDetailRepository OrderDetail { get; } // OrderDetail
        IOrderHeaderRepository OrderHeader { get; } // OrderHeader

        // Save
        void Save();
    }
}
