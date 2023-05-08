using Identity.Domain.Entities;

namespace Identity.Infra.Interfaces
{
    public interface IBaseRepository<T> where T : Base
    {
        Task<T> Create(T obj);
        Task<T> Update(T obj);
        Task Remove(long Id);
        Task<T> Get(long Id);
        Task<List<T>> Get();
    }
}