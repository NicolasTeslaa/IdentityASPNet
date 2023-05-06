using Identity.Domain.Entities;

namespace Identity.Infra.Interfaces
{
    public interface IBaseRepository<T> where T : Base
    {
         Task<T> Create(T obj);

         
    }
}