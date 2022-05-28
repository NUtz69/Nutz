using Nutz.DataAccess.Respository.IRespository;
using Nutz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Respository
{
    // 005 - Shopping Cart
    public class ApplicationUserRespository : Respository<ApplicationUser>, IApplicationUserRespository
    {
        // Var
        private readonly ApplicationDbContext _db;

        // ctor
        public ApplicationUserRespository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

    }
}
