using AutoMapper;
using Identity.Core.Exceptions;
using Identity.Domain.Entities;
using Identity.Infra.Interfaces;
using Identity.Services.DTO;

namespace Identity.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<UserDTO> Create(UserDTO userDTO)
        {
            var userExistente = await _userRepository.GetByEmail(userDTO.Email);
            if (userExistente != null)
                throw new DomainException("Já existe um usuário cadastrado com esse email");

            var user = _mapper.Map<User>(userDTO);
            var userCreated = await _userRepository.Create(user);
            return _mapper.Map<UserDTO>(userCreated);
        }

        public Task<UserDTO> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDTO>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task Remove(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDTO>> SearchByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDTO>> SearchByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> Update(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}