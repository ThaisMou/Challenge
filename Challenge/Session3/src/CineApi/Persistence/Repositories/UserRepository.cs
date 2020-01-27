using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CineApi.Domain.Repositories;
using CineApi.Persistence.Contexts;

namespace CineApi.Persistence.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(CineContext context) : base(context)
        { }
        public async Task<IEnumerable<User>> ListAsync()
        {
            return await _context.User.ToListAsync();
        }
        public async Task AddAsync(User user)
        {
            await _context.User.AddAsync(user);
        }
        public async Task<User> FindByIdAsync(int id)
        {
            return await _context.User.FindAsync(id);
        }       
        public void Remove(User user)
        {
            _context.User.Remove(user);
        }
        public void Update(User user)
        {
            _context.User.Update(user);
        }     
    }
}