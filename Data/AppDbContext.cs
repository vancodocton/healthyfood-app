using Microsoft.EntityFrameworkCore;

namespace asp_dotnet_core_healthyfood_app.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        #region DbSet
        public DbSet<Category>? Categories { get; set; }
        public DbSet<CategoryType>? CategoryTypes { get; set;}

        #endregion
    }
}
