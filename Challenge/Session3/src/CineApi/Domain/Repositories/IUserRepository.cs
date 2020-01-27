using System.Collections.Generic;
using System.Threading.Tasks;
using CineApi.Models;

namespace CineApi.Domain
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> ListAsync();
        Task AddAsync (User user);
        Task<User> FindIdAsync(int id);
        void Update (User user);
        void Remove (User user);        
    }
}