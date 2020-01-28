using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CineFlix.Models;
using CineFlix.Services;

namespace CineFlix.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController 
    {
        private UserRepository userRepository;
        public UserController()
        {
            this.userRepository = new UserRepository();
        }

        [HttpGet]
        public User[] Get()
        {
            return userRepository.GetAllUsers();
        }
    }
}