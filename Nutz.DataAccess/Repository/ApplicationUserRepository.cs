using Nutz.DataAccess.Repository.IRepository;
using Nutz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Repository
{
    // 005 - Shopping Cart
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        // Var
        private readonly ApplicationDbContext _db;

        // ctor
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

    }
}
