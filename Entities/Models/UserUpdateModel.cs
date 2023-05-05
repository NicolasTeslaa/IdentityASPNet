using Microsoft.AspNetCore.Identity;

namespace IdentityASPNet.Identity
{
    public class UserUpdateModel
    {
        public string Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Password { get; set; }
        public string ConfPassword { get; set; }
    }
}