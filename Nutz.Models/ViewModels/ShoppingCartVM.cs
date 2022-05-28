using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.Models.ViewModels
{
    // 005 - Shopping Cart
    public class ShoppingCartVM
    {
        public IEnumerable<ShoppingCart> ListCart { get; set; } // ListCart
        public double CartTotal { get; set; } // CartTotal
    }
}
