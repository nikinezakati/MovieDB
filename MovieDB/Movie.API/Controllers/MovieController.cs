using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shared;

namespace Movie.API
{
    
    [ApiController]
    [Route("api/movie")]
    public class MovieController : ControllerBase
    {
        private MovieRepository _movieRepo;
        public MovieController(MovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
        }

        [HttpGet("findbyname/{name}")]
        public List<string> GetByName(string name)
        {
            return _movieRepo.FindByName(name);
        }
        [HttpGet("allmovies")]
        public List<string> GetAllMovies()
        {
            return _movieRepo.GetAll();
        }
    }
}