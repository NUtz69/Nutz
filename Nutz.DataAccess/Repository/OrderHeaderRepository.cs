using Nutz.DataAccess.Repository.IRepository;
using Nutz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Repository
{
    // 006 - Order
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        // Var
        private readonly ApplicationDbContext _db;

        // ctor
        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        // Update
        public void Update(OrderHeader obj)
        {
            _db.OrderHeaders.Update(obj);
        }

        // Update Status
        public void UpdateStatus(int id, string orderStatus, string? paymentStatus = null)
        {
            var orderFromDb = _db.OrderHeaders.FirstOrDefault(u => u.Id == id);

            if (orderFromDb != null)
            {
                orderFromDb.OrderStatus = orderStatus;

                if (paymentStatus != null)
                {
                    orderFromDb.PaymentStatus = paymentStatus;
                }
            }
        }

        // UpdateStripePaymentID
        public void UpdateStripePaymentID(int id, string sessionId, string paymentIntentId)
        {
            var orderFromDb = _db.OrderHeaders.FirstOrDefault(u => u.Id == id);

            orderFromDb.SessionId = sessionId;
            orderFromDb.PaymentIntentId = paymentIntentId;
        }
    }
}
