using Identity.Domain.Entities;

namespace Identity.Infra.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
         Task<User> GetByEmail (string email);
         
    }
}