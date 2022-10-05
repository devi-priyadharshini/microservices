using Microsoft.EntityFrameworkCore;
using platformservice.Model;

namespace platformservice.Data
{

    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
                            : base(options)
        {

        }

        public DbSet<Platform> Platforms
        {
            get; set;
        }
    }
}