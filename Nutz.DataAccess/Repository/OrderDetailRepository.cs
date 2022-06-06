using Nutz.DataAccess.Repository.IRepository;
using Nutz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Repository
{
    // 006 - Order
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        // Var
        private readonly ApplicationDbContext _db;

        // ctor
        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        // Update
        public void Update(OrderDetail obj)
        {
            _db.OrderDetails.Update(obj);
        }
    }
}
