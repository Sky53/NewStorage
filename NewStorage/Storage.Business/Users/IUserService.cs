using Storage.Business.Users.DTO;
using System.Threading.Tasks;

namespace Storage.Business.Users
{
    public interface IUserService
    {
        public Task<int> AddAsync(UserRequest userRequest);

        public Task<UserResponse> GetByIdAsync(int id);

        public Task<UserResponse> UpdateAsync(int id, UserRequest userRequest);

        public Task DeleteAsync(int id);
    }
}
