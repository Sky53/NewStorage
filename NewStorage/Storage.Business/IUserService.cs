using Storage.Business.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Business
{
    public interface IUserService
    {
        public Task<int> AddUserAsync(UserDTO productDTO);

        public Task<UserDTO> FindUserAsyncById(int id);

        public void UpdateUserAsync(UserDTO userDTO);

        public Task<int> DeleteUserAsync(int id);
    }
}
