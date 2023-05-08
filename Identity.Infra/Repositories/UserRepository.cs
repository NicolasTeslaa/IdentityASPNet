using Identity.Domain.Entities;
using Identity.Infra.Context;
using Identity.Infra.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Identity.Infra.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly ManagerContext _context;

        public UserRepository(ManagerContext context) : base(context)
        {
            _context = context;
        }
        public async Task<User> GetByEmail(string email)
        {
            var user = await _context.Users
                                                    .Where(
                                                        x => x.Email.ToLower() == email.ToLower()
                                                    )
                                                    .AsNoTracking()
                                                    .ToListAsync();
            return user.FirstOrDefault();
        }

        public async Task<List<User>> SearchByEmail(string email)
        {
            var allUsers = await _context.Users
                                                            .Where(
                                                                 x => x.Email.ToLower() == email.ToLower()
                                                            )
                                                            .AsNoTracking()
                                                            .ToListAsync();
            return allUsers;
        }

        public Task<List<User>> SearchByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}