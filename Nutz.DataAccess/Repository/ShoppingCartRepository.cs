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
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        // Var
        private readonly ApplicationDbContext _db;

        // ctor
        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        // IncrementCount
        public int IncrementCount(ShoppingCart shoppingCart, int count)
        {
            shoppingCart.Count += count;

            return shoppingCart.Count;
        }

        // DecrementCount
        public int DecrementCount(ShoppingCart shoppingCart, int count)
        {
            shoppingCart.Count -= count;

            return shoppingCart.Count;
        }

    }
}
