using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace SportsStore.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts)
            : base(opts)
        {
        }

        public DbSet<Product> Products { get; set; }

        public class ApplicationDbContextFactory
        : IDesignTimeDbContextFactory<DataContext>
        {

            public DataContext CreateDbContext(string[] args) =>
                Program.BuildWebHost(args).Services
                    .GetRequiredService<DataContext>();
        }
    }
}