using Identity.Domain.Entities;
using Identity.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Identity.Infra.Context
{
    public class ManagerContext : DbContext
    {
        public ManagerContext() { }
        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsnuilder)
        {
            optionsnuilder.UseSqlServer("Server=tcp:identityserverr.database.windows.net,1433;Initial Catalog=identity;Persist Security Info=False;User ID=teslaadmin;Password=Bancosql@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
        }
    }
}