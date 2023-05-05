namespace Identity.Domain.Entities
{
    public class User : Base
    {
        public string Username { get; set; }
        public string NomeCompleto { get; set; }

        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}