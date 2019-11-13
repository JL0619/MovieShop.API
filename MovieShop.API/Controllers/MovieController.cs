using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieShop.Data;
using MovieShop.Entity;
using MovieShop.Services;

namespace MovieShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
          public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        [HttpGet]
        [Route("topgrossing")]
        public async Task<IActionResult> GetTopGrossingMovie()
        {
            var movies = await _movieService.GetHighestGrossingMovie();
            return Ok(movies);
        }
        
    }
  
}