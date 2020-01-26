using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Storage.DAL.Repository
{
    public interface IUserRepository
    {
        public Task<int> SaveAsync(User user);

        public Task<User> FindByIdAsync(int id);

        public void UpdateAsync(User user);

        public Task<int> DeleteAsync(int id);
    }
}
