using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using CineFlixApi.Models;

namespace CineFlixApi.Controllers
{
    public class UserController : ApiController
    {
        private readonly User[] Users = new User[]
       {
           new User { Id = 1, FirstName = "Adam", LastName = "Smith", MovieId = 1 },
           new User { Id = 2, FirstName = "Ravi", LastName = "Kumar", MovieId = 2 },
        };

        // GET api/User
        public User[] Get()
        {
            return Users;
        }

        // GET api/User/5
        public User Get(int id)
        {
            var users = Users;
            return users.SingleOrDefault(u => u.Id == id);
        } 

        // POST api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/User/5
        public void Delete(int id)
        {
        }
    }
}
