using Nutz.DataAccess.Respository.IRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Respository
{
    // 001 - Repository Pattern
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
        }

        // Get
        public ICategoryRespository Category { get; private set; } // Category
        public ICoverTypeRespository CoverType { get; private set; } // CoverType

        // Save
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
