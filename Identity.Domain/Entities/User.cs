namespace Identity.Domain.Entities
{
    public class User : Base
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        protected User() { }
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
        public override bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}