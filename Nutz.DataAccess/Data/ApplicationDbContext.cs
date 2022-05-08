using Microsoft.EntityFrameworkCore;
using Nutz.Models;

namespace Nutz.DataAccess
{
    // 002 - Product Management
    public class ApplicationDbContext : DbContext
    {
        // ctor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // DbSet

        // Category
        public DbSet<Category> Categories { get; set; }
        // CoverType
        public DbSet<CoverType> CoverTypes { get; set; }
        // Product
        public DbSet<Product> Products { get; set; }

    }
}
