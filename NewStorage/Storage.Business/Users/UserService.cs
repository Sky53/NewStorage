using AutoMapper;
using Storage.Business.Users.DTO;
using Storage.DAL.Repository;
using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Business.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<int> AddAsync(UserRequest userRequest)
        {
            var user = _mapper.Map<User>(userRequest);

            return await _userRepository.SaveAsync(user);
        }

        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<UserResponse> GetByIdAsync(int id)
        {
            var user = await _userRepository.FindByIdAsync(id);

            return _mapper.Map<UserResponse>(user);
        }

        public async Task<UserResponse> UpdateAsync(int id, UserRequest userRequest)
        {
            var user = _mapper.Map<User>(userRequest);
            user.Id = id;

            await _userRepository.UpdateAsync(user);

            return _mapper.Map<UserResponse>(user);
        }
    }
}
