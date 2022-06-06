using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.Models.ViewModels
{
    // 006 - Order
    public class ShoppingCartVM
    {
        public IEnumerable<ShoppingCart> ListCart { get; set; } // ListCart        
        public OrderHeader OrderHeader { get; set; } // OrderHeader
    }
}
