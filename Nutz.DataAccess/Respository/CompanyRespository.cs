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
    public class CompanyRespository : Respository<Company>, ICompanyRespository
    {
        // Var
        private readonly ApplicationDbContext _db;

        // ctor
        public CompanyRespository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        // Update
        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
