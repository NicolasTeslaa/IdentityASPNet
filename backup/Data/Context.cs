using IdentityASPNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityASPNet.Data
{
    public class Context : DbContext
    // <User, Role, int, IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public Context()
        {

        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
                
        }

        public DbSet<User> Usuarios { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);

        //     modelBuilder.Entity<UserRole>(userRole =>
        //     {
        //         userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

        //         userRole.HasOne(ur => ur.Role)
        //                         .WithMany(r => r.UserRoles)
        //                         .HasForeignKey(ur => ur.RoleId)
        //                         .IsRequired();

        //         userRole.HasOne(ur => ur.User)
        //                         .WithMany(r => r.UserRoles)
        //                         .HasForeignKey(ur => ur.UserId)
        //                         .IsRequired();
        //     });
        // }
  }
}