using Nutz.DataAccess.Repository.IRepository;
using Nutz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Repository
{
    // 001 - Repository Pattern
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        // Var
        private readonly ApplicationDbContext _db;

        // ctor
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        // Update
        public void Update(CoverType obj)
        {
            _db.CoverTypes.Update(obj);
        }
    }
}
