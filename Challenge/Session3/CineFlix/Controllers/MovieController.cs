using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CineFlix.Services;
using CineFlix.Models;

namespace CineFlix.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MovieController
    {
        private MovieRepository movieRepository;
        public MovieController()
        {
            this.movieRepository = new MovieRepository();
        }

        [HttpGet]
        public Movie[] GetMovie()
        {
            return movieRepository.GetAllMovies();
            
        }             
    }
}

