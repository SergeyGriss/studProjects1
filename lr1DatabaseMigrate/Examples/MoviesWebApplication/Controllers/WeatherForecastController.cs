using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesWebApplication.Models;

namespace MoviesWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        [HttpGet]
        public IEnumerable<Movies> Get()
        {
            using (var _context  = new MoviesDBContext())
            {
                /*Movies movie = new Movies();
                //movie.MoviesId = 1;
                movie.Name = "First Title";
                movie.Year = 2000;

                _context.Movies.Add(movie);

                _context.SaveChanges();*/
                return _context.Movies.ToList();
            }


        }
    }
}
