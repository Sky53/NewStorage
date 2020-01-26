using AutoMapper;
using Storage.Business.DTO;
using Storage.DAL.Repository;
using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Business
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<int> AddUserAsync(UserDTO UserDTO)
        {
            var user = _mapper.Map<User>(UserDTO);
            return await _userRepository.SaveAsync(user);
        }

        public async Task<int> DeleteUserAsync(int id)
        {
            return await _userRepository.DeleteAsync(id);
        }

        public async Task<UserDTO> FindUserAsyncById(int id)
        {
            var user = await _userRepository.FindByIdAsync(id);
            return _mapper.Map<UserDTO>(user);
        }

        public void UpdateUserAsync(UserDTO userDTO)
        {
            var user = _mapper.Map<User>(userDTO);
            _userRepository.UpdateAsync(user);
        }
    }
}
