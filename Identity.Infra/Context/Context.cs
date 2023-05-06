using Identity.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Identity.Infra.Context
{
    public class Context : DbContext
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options){ }
        public DbSet<User> Usuarios { get; set; }
    }
}