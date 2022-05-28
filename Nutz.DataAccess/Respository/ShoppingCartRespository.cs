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
    public class ShoppingCartRespository : Respository<ShoppingCart>, IShoppingCartRespository
    {
        // Var
        private readonly ApplicationDbContext _db;

        // ctor
        public ShoppingCartRespository(ApplicationDbContext db) : base(db)
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
