using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nutz.Models;

namespace Nutz.DataAccess
{
    // 005 - Shopping Cart
    public class ApplicationDbContext : IdentityDbContext
    {
        // ctor
        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        #pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }

        // DbSet        
        public DbSet<Category> Categories { get; set; } // Category
        public DbSet<CoverType> CoverTypes { get; set; } // CoverType
        public DbSet<Product> Products { get; set; } // Product        
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } // ApplicationUser
        public DbSet<Company> Companies { get; set; } // Company
        public DbSet<ShoppingCart> ShoppingCarts { get; set; } // ShoppingCart

    }
}
