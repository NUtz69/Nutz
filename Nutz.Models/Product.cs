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
    // 002 - Product Management
    public class Product
    {
        public int Id { get; set; } // Id
        [Required]
        public string? Title { get; set; } // Title
        public string? Description { get; set; } // Description
        [Required]
        public string? ISBN { get; set; } // ISBN
        [Required]
        public string? Author { get; set; } // Author
        [Required]
        [Display(Name = " List Price")]
        [Range(1, 10000)]
        public double ListPrice { get; set; } // ListPrice
        [Required]
        [Display(Name = "Price for 1-50")]
        [Range(1, 10000)]
        public double Price { get; set; } // Price

        [Required]
        [Display(Name = "Price for 51-100")]
        [Range(1, 10000)]
        public double Price50 { get; set; } // Price50
        [Required]
        [Display(Name = "Price for 100+")]
        [Range(1, 10000)]
        public double Price100 { get; set; } // Price100

        [ValidateNever]
        [Display(Name = "Image")]
        public string? ImageUrl { get; set; } // ImageUrl

        // ForeignKey
        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; } // CategoryId
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category? Category { get; set; } // Category

        [Required]
        [Display(Name = "Cover Type")]
        public int CoverTypeId { get; set; } // CoverTypeId
        [ValidateNever]
        public CoverType? CoverType { get; set; } // CoverType
    }
}
