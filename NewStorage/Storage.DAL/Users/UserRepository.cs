using Storage.DAL.Exception;
using Storage.Domain;
using System.Threading.Tasks;

namespace Storage.DAL.Products
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
                throw new StorageException("Can't save an empty user");
            }

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user.Id;
        }

        public async Task<User> UpdateAsync(User user)
        {
            if (user == null)
            {
                throw new StorageException("Can't save an empty user");
            }

            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return user;
        }
    }
}
