using Microsoft.EntityFrameworkCore;
using Nutz.Models;

namespace Nutz.DataAccess
{
    // 002 - Product Management
    public class ApplicationDbContext : DbContext
    {
        // ctor
        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        #pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }

        // DbSet

        // Category
        public DbSet<Category> Categories { get; set; }
        // CoverType
        public DbSet<CoverType> CoverTypes { get; set; }
        // Product
        public DbSet<Product> Products { get; set; }
        // ShoppingCart
        //public DbSet<ShoppingCart> ShoppingCart { get; set; }

    }
}
