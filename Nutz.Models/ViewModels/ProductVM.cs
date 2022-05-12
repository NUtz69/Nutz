using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.Models.ViewModels
{
    // 002 - Product Management
    public class ProductVM
    {
        // Get
        public Product Product { get; set; } // product
        [ValidateNever]
        public IEnumerable<SelectListItem> CategoryList { get; set; } // CategoryList
        [ValidateNever]
        public IEnumerable<SelectListItem> CoverTypeList { get; set; } // CoverTypeList
    }
}
