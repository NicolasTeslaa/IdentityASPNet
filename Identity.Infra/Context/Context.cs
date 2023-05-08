using Identity.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Identity.Infra.Context
{
    public class ManagerContext : DbContext
    {
        public ManagerContext() { }
        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options){ }
        public DbSet<User> Users { get; set; }
    }
}