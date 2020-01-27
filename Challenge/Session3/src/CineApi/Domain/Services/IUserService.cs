using System.Collections.Generic;
using System.Threading.Tasks;
using CineApi.Models;

namespace CineApi.Domain
{
    public interface IUserService
    {
        Task<IEnumerable<User>> ListAsync();        
    }
}