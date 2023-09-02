using Microsoft.EntityFrameworkCore;
using PharmacyAppServer.Models;

namespace PharmacyAppServer.DA
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Drug> Drugs { get; set; } = null;
        public DbSet<Provider> Providers { get; set; } = null;
        public DbSet<Group> Groups { get; set; } = null;
        public DbSet<Deliveries> Deliveries { get; set; } = null;
        public DbSet<Sales> Sales { get; set; } = null;
        public DbSet<Warehouse> Warehouses { get; set; } = null;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
    }
}
