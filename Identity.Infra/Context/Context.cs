using Identity.Domain.Entities;
using Identity.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Identity.Infra.Context
{
    public class ManagerContext : DbContext
    {
        public ManagerContext() { }
        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options) { }


        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
        }
    }
}