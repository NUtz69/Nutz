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
    public class CategoryRepository : Repository<Category>, IOrderHeaderRespository
    {
        // Var
        private readonly ApplicationDbContext _db;

        // ctor
        public CategoryRepository(ApplicationDbContext db) : base(db)
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
