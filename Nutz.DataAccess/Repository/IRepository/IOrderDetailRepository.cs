using Nutz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Repository.IRepository
{
    // 006 - Order
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        // Update
        void Update(OrderDetail obj);
    }
}
