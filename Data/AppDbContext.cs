using azure_db_web_app.Models;
using Microsoft.EntityFrameworkCore;

namespace azure_db_web_app.Data
{
  
    
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
            public DbSet<Product> Product { get; set; } = default!;
        }
    
}
