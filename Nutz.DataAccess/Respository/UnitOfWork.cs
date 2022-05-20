using Nutz.DataAccess.Respository.IRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Respository
{
    // 004 - Identity Management
    public class UnitOfWork : IUnitOfWork
    {
        // Var
        private readonly ApplicationDbContext _db;

        // ctor
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRespository(_db);
            CoverType = new CoverTypeRespository(_db);
            Product = new ProductRespository(_db);
            Company = new CompanyRespository(_db);
        }

        // Get
        public ICategoryRespository Category { get; private set; } // Category
        public ICoverTypeRespository CoverType { get; private set; } // CoverType
        public IProductRespository  Product { get; private set; } // Product
        public ICompanyRespository Company { get; private set; } // Company

        // Save
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
