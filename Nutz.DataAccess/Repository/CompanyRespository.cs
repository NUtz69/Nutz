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
    public class CompanyRespository : Repository<Company>, ICompanyRepository
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
