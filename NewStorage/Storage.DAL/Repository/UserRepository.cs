using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Storage.DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly StorageContext _context;

        public UserRepository(StorageContext context)
        {
            _context = context;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var userDelete = await _context.Users.FindAsync(id);
            if (userDelete != null)
            {
                _context.Users.Remove(userDelete);
                await _context.SaveChangesAsync();
                return userDelete.Id;
            }
            else
            {
                throw new NotImplementedException();
            }

        }

        public async Task<User> FindByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<int> SaveAsync(User user)
        {
            if (user != null)
            {
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                return user.Id;
            }
            else
            {
                throw new NotImplementedException();
            }
           
        }

        public async void UpdateAsync(User user)
        {
            if (user != null)
            {
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
