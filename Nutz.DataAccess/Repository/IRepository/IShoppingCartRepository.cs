using Nutz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Repository.IRepository
{
    // 005 - Shopping Cart
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        int IncrementCount(ShoppingCart shoppingCart, int count); // IncrementCount
        int DecrementCount(ShoppingCart shoppingCart, int count); // DecrementCount
    }
}
