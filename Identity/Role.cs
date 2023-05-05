using Microsoft.AspNetCore.Identity;

namespace IdentityASPNet.Identity
{
    public class Role 
    {
        public IEnumerable<UserRole> UserRoles { get; set; }
        
    }
}