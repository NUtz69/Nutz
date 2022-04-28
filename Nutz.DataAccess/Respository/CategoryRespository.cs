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
    public class CategoryRespository : Respository<Category>, ICategoryRespository
    {
        // Var
        private readonly ApplicationDbContext _db;

        // ctor
        public CategoryRespository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        // Update
        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
