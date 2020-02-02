using Storage.DAL.Exception;
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

        public async Task DeleteAsync(int id)
        {
            var user = new User()
            {
                Id = id
            };

            _context.Users.Remove(user);
            var userDelete = await _context.Users.FindAsync(id);
            await _context.SaveChangesAsync();
        }


        public async Task<User> FindByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<int> SaveAsync(User user)
        {
            if (user == null)
            {
                throw new StorageException();
            }

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user.Id;
        }

        public async Task<User> UpdateAsync(User user)
        {
            if (user == null)
            {
                throw new StorageException();
            }

            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return user;

        }
    }
}
