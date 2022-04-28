using Nutz.DataAccess.Respository.IRespository;
using Nutz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Respository
{
    // 001 - Repository Pattern
    public class CoverTypeRespository : Respository<CoverType>, ICoverTypeRespository
    {
        // Var
        private readonly ApplicationDbContext _db;

        // ctor
        public CoverTypeRespository(ApplicationDbContext db) : base(db)
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
