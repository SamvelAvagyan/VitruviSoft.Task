using BusinessObjects;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        { }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Provider> Providers { get; set; }
    }
}
