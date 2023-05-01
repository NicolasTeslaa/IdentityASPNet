namespace IdentityASPNet.Entities
{
    public class Usuario
    {
        public string Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Password { get; set; }
        public string ConfPassword { get; set; }
    }
}