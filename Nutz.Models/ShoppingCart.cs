using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.Models
{
    // 005 - Shopping Cart
    public class ShoppingCart
    {
        // Id
        public int Id { get; set; }

        // ProductId
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        [ValidateNever]
        // Product
        public Product? Product { get; set; }
        // Count
        [Range(1, 1000, ErrorMessage = "Please enter a value between 1 and 1000 !")]
        public int Count { get; set; }

        // ApplicationUserId
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }

        // Price
        [NotMapped]
        public double Price { get; set; }
    }
}
