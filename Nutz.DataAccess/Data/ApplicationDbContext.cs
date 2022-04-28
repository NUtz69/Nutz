using Microsoft.EntityFrameworkCore;
using Nutz.Models;

namespace Nutz.DataAccess
{
    // 001 - Repository Pattern
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
    }
}
