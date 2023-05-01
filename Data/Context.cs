using IdentityASPNet.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdentityASPNet.Data
{
    public class Context : DbContext
    {
        public Context()
        {

        }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}