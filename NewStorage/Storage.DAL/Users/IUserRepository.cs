using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Storage.DAL.Products
{
    public interface IUserRepository
    {
        public Task<int> SaveAsync(User user);

        public Task<User> FindByIdAsync(int id);

        public Task<User> UpdateAsync(User user);

        public Task DeleteAsync(int id);
    }
}
