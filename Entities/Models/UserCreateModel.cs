using Microsoft.AspNetCore.Identity;

namespace IdentityASPNet.Identity
{
    public class UserCreateModel
    {
        public string NomeCompleto { get; set; }
        public string Password { get; set; }
        public string ConfPassword { get; set; }
    }
}