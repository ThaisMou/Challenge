using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CineFlix.Models;

namespace CineFlix.Services
{
    public class MovieRepository
    {
        public Movie[] GetAllMovies()
        {
                return new Movie[]
                {
                new Movie { Id = 1, Title = "ASSASSIN'S CREED: EMBERS", Category = "Animation"},
                new Movie { Id = 1, Title = "Real Steel(2012)", Category = "Animation"},
                new Movie { Id = 1, Title = "Alvin and the Chipmunks", Category = "Animation"},
                new Movie { Id = 1, Title = "The Adventures of Tin Tin", Category = "Animation"},
                new Movie { Id = 1, Title = "Safe (2012)", Category = "Action"},
                new Movie { Id = 1, Title = "Safe House(2012)", Category = "Action"},
                new Movie { Id = 1, Title = "GIA", Category = "18+"},
                new Movie { Id = 1, Title = "Deadline 2009", Category = "18+"},
                new Movie { Id = 1, Title = "The Dirty Picture", Category = "18+"},
                new Movie { Id = 1, Title = "Marley and me", Category = "Romance"}
                };
        }

    }
}

