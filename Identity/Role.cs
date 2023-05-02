using Microsoft.AspNetCore.Identity;

namespace IdentityASPNet.Identity
{
    public class Role : IdentityRole<int>
    {
        public IEnumerable<UserRole> UserRoles { get; set; }
        
    }
}