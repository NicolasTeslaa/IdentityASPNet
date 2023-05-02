using Microsoft.AspNetCore.Identity;

namespace IdentityASPNet.Identity
{
    public class User : IdentityUser<int>
    {
        public string Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Password { get; set; }
        public string ConfPassword { get; set; }
        public IEnumerable<UserRole> UserRoles { get; set; }
    }
}