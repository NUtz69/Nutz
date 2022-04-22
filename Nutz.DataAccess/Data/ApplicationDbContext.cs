using Microsoft.EntityFrameworkCore;
using Nutz.Models;

namespace Nutz.DataAccess
{
    // 000 - Create Project
    public class ApplicationDbContext : DbContext
    {
        // ctor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // DbSet
        public DbSet<Category> Categories { get; set; }
    }
}
