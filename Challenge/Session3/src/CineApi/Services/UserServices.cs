using System.Collections.Generic;
using System.Threading.Tasks;
using CineApi.Domain.Services;
using CineApi.Domain.Repositories;

namespace CineApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IEnumerable<User>> ListAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}