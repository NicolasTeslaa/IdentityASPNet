using Identity.Services.DTO;

namespace Identity.Services
{
    public interface IUserService
    {
        Task<UserDTO> Create(UserDTO userDTO);
    }
}