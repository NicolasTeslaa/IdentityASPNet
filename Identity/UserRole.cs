using Microsoft.AspNetCore.Identity;

namespace IdentityASPNet.Identity
{
    public class UserRole 
    {
       public User User { get; set; }
       public Role Role { get; set; }
    }
}