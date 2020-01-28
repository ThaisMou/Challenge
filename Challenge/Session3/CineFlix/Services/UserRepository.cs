using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CineFlix.Models;

namespace CineFlix.Services
{
    public class UserRepository
    {
        public User[] GetAllUsers()
        {
            return new User[]
            {
                new User { Id = 1, FirstName = "Adam", LastName = "Smith", MovieId = 1},
                new User { Id = 2, FirstName = "Ravi", LastName = "Kumar", MovieId = 2},
                new User { Id = 3, FirstName = "Susan", LastName = "Davidson", MovieId = 5},
                new User { Id = 4, FirstName = "Jenny", LastName = "Adrianna", MovieId = 8},
                new User { Id = 6, FirstName = "Lee", LastName = "Pong", MovieId = 10}
            };
        }
    }
}
