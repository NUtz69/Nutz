using Nutz.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Repository
{
    // 005 - Shopping Cart
    public class UnitOfWork : IUnitOfWork
    {
        // Var
        private readonly ApplicationDbContext _db;

        // ctor
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);
            Company = new CompanyRespository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
            ShoppingCart = new ShoppingCartRepository(_db);
            OrderHeader = new OrderHeaderRepository(_db);
            OrderDetail = new OrderDetailRepository(_db);
        }

        // Get
        public IOrderHeaderRespository Category { get; private set; } // Category
        public ICoverTypeRepository CoverType { get; private set; } // CoverType
        public IProductRepository  Product { get; private set; } // Product
        public ICompanyRepository Company { get; private set; } // Company
        public IShoppingCartRepository ShoppingCart { get; private set; } // ShoppingCart
        public IApplicationUserRepository ApplicationUser { get; private set; } // ApplicationUser
        // 006 - Order
        public IOrderHeaderRepository OrderHeader { get; private set; } // OrderDetail
        public IOrderDetailRepository OrderDetail { get; private set; } // OrderHeader

        // Save
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
