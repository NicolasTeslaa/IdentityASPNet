using Identity.Domain.Entities;
using Identity.Infra.Interfaces;
using Identity.Infra.Context;
namespace Identity.Infra.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Base
    {
        private readonly ManagerContext _context;

        public BaseRepository(ManagerContext context)
        {
            _context = context;
        }
        public Task<T> Create(T obj)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> Get()
        {
            throw new NotImplementedException();
        }

        public Task Remove(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}